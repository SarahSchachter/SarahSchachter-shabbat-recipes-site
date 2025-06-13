using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.service
{
    public interface IIngredient_RecipeService
    {
        
        List<Ingredient> GetIngredientRecipe(int id_recipe);
        void AddIngredientOfRecipe(int id_recipe, Dictionary<int, string> Ingredients);
    }
}



