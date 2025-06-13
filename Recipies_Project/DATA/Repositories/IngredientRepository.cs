
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        DataContex _contex;

        public IngredientRepository(DataContex contex) { _contex = contex; }
        public List<Ingredient> GetAll()
        {
            
            return _contex.Ingredients.ToList();
        }
        public void AddIngredient(string name)
        {
            // בדוק אם מצרך עם השם הנתון כבר קיים במסד הנתונים
            var existingIngredient = _contex.Ingredients.FirstOrDefault(i => i.Name == name);

            if (existingIngredient == null)
            {
                // אם המצרך לא קיים, צור חדש והוסף אותו
                var newIngredient = new Ingredient()
                {
                    Id = _contex.Ingredients.Count() + 1,
                    Name = name
                };

                _contex.Ingredients.Add(newIngredient);
                _contex.SaveChanges();
            }
            else
            {
                // אם המצרך כבר קיים, אתה יכול לבחור מה לעשות
                Console.WriteLine($"המצרך '{name}' כבר קיים במערכת.");
            }
        }
    }
}