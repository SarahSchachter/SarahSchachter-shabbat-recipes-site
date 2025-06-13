using CORE.service;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        IRecipeService _recipeService;
        public RecipeController(IRecipeService recipeService)
        { _recipeService = recipeService;
        }



        [HttpGet]
        public List<Recipe> Get()
        {
            return _recipeService.GetAll();
        }

        [HttpGet("{id}")]
        public Recipe Get(int id)
        {
            return _recipeService.GetById(id);
        }

        [HttpPost]
        public Recipe Post(Recipe recipe)
        {
            _recipeService.AddRecipe(recipe);
            return recipe;

        }
    } }
