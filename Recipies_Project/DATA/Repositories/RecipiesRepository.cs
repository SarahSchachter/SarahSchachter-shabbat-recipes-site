using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.repositories
{
    public class RecipiesRepository:IRecipiesRepository
    {
        DataContex _contex;

        public RecipiesRepository(DataContex contex) { _contex = contex; }

        public List<Recipe> GetAll()
        {
            return _contex.Recipes.ToList();

        }
        //(incliud)

        public Recipe GetById(int id)
        {
            return _contex.Recipes.FirstOrDefault(x => x.Id == id);
        }

        public Recipe AddRecipe(Recipe recipe)
        {
            recipe.Id = _contex.Recipes.Count() + 1;
            _contex.Recipes.Add(recipe);
            _contex.SaveChanges();
            return recipe;
            }
    }
}
