using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.repositories
{
    public interface IIngredient_RecipeRepository
    {
        List<Ingredient> GetIngredientRecipe(int id_recipe);  
         void AddIngredientOfRecipe(int id_recipe, Dictionary<int,string> Ingredients);
    }
}
