using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeganDaddy.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VeganDaddy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IUserProfileRepository _userProfileRepository;

        public RecipeController(IRecipeRepository recipeRepository, IUserProfileRepository userProfileRepository)
        {
            _recipeRepository = recipeRepository;
            _userProfileRepository = userProfileRepository;
        }
        // GET: api/<RecipeController>
        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok(_recipeRepository.GetAllRecipes());
        }

        // GET api/<RecipeController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<RecipeController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<RecipeController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<RecipeController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
