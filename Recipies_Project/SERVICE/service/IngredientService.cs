using CORE.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.service
{
    public class IngredientService: IIngredientService
    {
        IIngredientRepository repository;

        public IngredientService(IIngredientRepository repository)
        {
            this.repository = repository;
        }

        public List<Ingredient> GetAll()
        {
            
            return repository.GetAll();
        }
       
      

        public void AddIngredient(string name)
        {
            repository.AddIngredient( name);
        }
    }
}
