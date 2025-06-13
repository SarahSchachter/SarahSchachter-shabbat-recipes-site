using CORE.service;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientRecipeController : ControllerBase
    {

        IIngredient_RecipeService _recipeService;

        public IngredientRecipeController(IIngredient_RecipeService recipeService) { _recipeService = recipeService; }


        [HttpGet("{id}")]
        public List<Ingredient> Get(int id)
        {
            return _recipeService.GetIngredientRecipe(id);
        }

        [HttpPost]
        public void Post(int id, Dictionary<int, string> ingredeins)

        {
            _recipeService.AddIngredientOfRecipe(id, ingredeins);
        }
    }
}

