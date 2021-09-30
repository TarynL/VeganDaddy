using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganDaddy.Models;
using VeganDaddy.Utils;

namespace VeganDaddy.Repositories
{
    public class RecipeRepository : BaseRepository, IRecipeRepository
    {
        public RecipeRepository(IConfiguration config) : base(config) { }

        public List<Recipe> GetAllRecipes()
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                                       SELECT r.Id, r.UserId, r.Title, r.Description, 
                                       r.Instructions, r.ImageUrl as RecipeImage, r.PostedDate, r.IsDeleted
                                       FROM Recipe r
                                       WHERE r.IsDeleted = 0
                                       ORDER BY r.PostedDate DESC";

                    var reader = cmd.ExecuteReader();

                    var recipes = new List<Recipe>();

                    while (reader.Read())
                    {
                        recipes.Add(NewRecipeFromReader(reader));
                    }
                    reader.Close();

                    return recipes;
                }
            }
        }

        public void Add(Recipe recipe) 
        {
            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        INSERT INTO Recipes (
                            Title, UserId, Description, Instructions, ImageUrl, PostedDate, IsDeleted )
                        OUTPUT INSERTED.ID
                        VALUES (
                            @Title,@UserId, @Description, @Instructions, @ImageUrl, @PostedDate, 0
                            )";
                    DbUtils.AddParameter(cmd, "@Title", recipe.Title);
                    DbUtils.AddParameter(cmd, "@UserId", recipe.UserId);
                    DbUtils.AddParameter(cmd, "@Description", recipe.Description);
                    DbUtils.AddParameter(cmd, "@Value", recipe.Instructions);
                    DbUtils.AddParameter(cmd, "@ImageUrl", recipe.ImageUrl);
                    DbUtils.AddParameter(cmd, "@PostedDate", recipe.PostedDate);


                    recipe.Id = (int)cmd.ExecuteScalar();
                }
            }
        }

        private Recipe NewRecipeFromReader(SqlDataReader reader)
        {
            return new Recipe()
            {
                Id = DbUtils.GetInt(reader, "Id"),
                UserId = DbUtils.GetInt(reader, "UserId"),
                Title = DbUtils.GetString(reader, "Title"),
                Description = DbUtils.GetString(reader, "Description"),
                Instructions = DbUtils.GetString(reader, "Instructions"),
                ImageUrl = DbUtils.GetString(reader, "RecipeImage"),
                PostedDate = DbUtils.GetDateTime(reader, "PostedDate"),
              
            };
        }

    }
}
