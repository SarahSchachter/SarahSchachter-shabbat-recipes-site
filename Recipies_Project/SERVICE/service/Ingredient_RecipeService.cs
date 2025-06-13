using CORE.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.service
{
    public class Ingredient_RecipeService : IIngredient_RecipeService
    {
        IIngredient_RecipeRepository _repository;

        public Ingredient_RecipeService(IIngredient_RecipeRepository repository) { _repository = repository; }




        public void AddIngredientOfRecipe(int id_recipe, Dictionary<int, string> Ingredients)
        {
            _repository.AddIngredientOfRecipe(id_recipe, Ingredients);
        }


        public List<Ingredient> GetIngredientRecipe(int id_recipe)
        {
            return _repository.GetIngredientRecipe(id_recipe);
        }


    }
}
