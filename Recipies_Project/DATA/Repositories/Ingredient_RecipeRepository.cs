using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.repositories
{
    public class Ingredient_RecipeRepository : IIngredient_RecipeRepository
    {
        DataContex _contex;

        public Ingredient_RecipeRepository(DataContex contex) { _contex = contex; }

        public void AddIngredientOfRecipe(int id_recipe, Dictionary<int, string> Ingredients)
        {
            foreach (var item in Ingredients) { 

                
                    _contex.IngredientRecipes.Add(new IngredientRecipe
                    {
                        Id = _contex.IngredientRecipes.Count() + 1,
                        Amount = item.Value,
                        IdIngredient = item.Key,
                        IdRecipe = id_recipe,
                    });
                    _contex.SaveChanges();
               }

        }

        //public void AddIngredientOfRecipe(int id_recipe, Dictionary<int, string> Ingredients)
        //{
        //    foreach (var item in Ingredients)
        //    {
        //        // לבדוק אם קיים כזה מרכיב בטבלת Ingredients
        //        var exists = _contex.Ingredients.Any(i => i.Id == item.Key);

        //        if (exists)
        //        {
        //            _contex.IngredientRecipes.Add(new IngredientRecipe
        //            {
        //                Id = _contex.IngredientRecipes.Count() + 1,
        //                Amount = item.Value,
        //                IdIngredient = item.Key,
        //                IdRecipe = id_recipe,
        //            });
        //            _contex.SaveChanges();
        //        }
        //        else
        //        {
        //            // אפשר גם לכתוב שורת לוג, או לזרוק חריגה
        //            Console.WriteLine($"Ingredient Id {item.Key} does not exist");
        //        }
        //    }
        //}


        //        public void AddIngredientOfRecipe(int id_recipe, Dictionary<int, string> Ingredients)
        //{
        //    foreach (var item in Ingredients)
        //    {
        //        // בדיקה אם הרכיב קיים בטבלת Ingredients
        //        var ingredientExists = _contex.Ingredients.Any(i => i.Id == item.Key);

        //        // בדיקה אם כבר קיים זוג כזה בטבלת IngredientRecipes
        //        var linkAlreadyExists = _contex.IngredientRecipes.Any(ir =>
        //            ir.IdIngredient == item.Key && ir.IdRecipe == id_recipe);

        //        if (ingredientExists && !linkAlreadyExists)
        //        {
        //            _contex.IngredientRecipes.Add(new IngredientRecipe
        //            {
        //                Id = _contex.IngredientRecipes.Count() + 1, // רק אם יש עמודת Id
        //                Amount = item.Value,
        //                IdIngredient = item.Key,
        //                IdRecipe = id_recipe,
        //            });
        //            _contex.SaveChanges();
        //        }
        //        else if (!ingredientExists)
        //        {
        //            Console.WriteLine($"Ingredient Id {item.Key} does not exist");
        //        }
        //        else if (linkAlreadyExists)
        //        {
        //            Console.WriteLine($"Ingredient Id {item.Key} already exists for Recipe Id {id_recipe}");
        //        }
        //    }
        //}


        public List<Ingredient> GetIngredientRecipe(int id_recipe)
        {
            var list = _contex.IngredientRecipes.Where(x => x.IdRecipe == id_recipe).Include(x=> x.IdIngredientNavigation).Select(i => i.IdIngredient).ToList();
            List<Ingredient> list_i = new List<Ingredient>();
            foreach (var item in list)

                foreach (var ingredient in _contex.Ingredients)
                    if (ingredient.Id == item.Value)
                        list_i.Add(ingredient);


            return list_i;

        }




    }
}
