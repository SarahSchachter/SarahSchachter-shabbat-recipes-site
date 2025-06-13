using CORE.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.service
{
    public class RecipeService:IRecipeService
    {


        IRecipiesRepository _recipe;

        public RecipeService(IRecipiesRepository recipiesRepository)
        {
            _recipe = recipiesRepository;
        }

        public List<Recipe>GetAll()
        {
            return _recipe.GetAll();
        }

        public Recipe GetById(int id)
        {
            return _recipe.GetById(id);
        }

        public Recipe AddRecipe(Recipe recipe)
        {
            _recipe.AddRecipe(recipe);
            return recipe;
        }
    }
}
