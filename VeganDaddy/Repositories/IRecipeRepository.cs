using System.Collections.Generic;
using VeganDaddy.Models;

namespace VeganDaddy.Repositories
{
    public interface IRecipeRepository
    {
        void Add(Recipe recipe);
       
        List<Recipe> GetAllRecipes();
    }
}