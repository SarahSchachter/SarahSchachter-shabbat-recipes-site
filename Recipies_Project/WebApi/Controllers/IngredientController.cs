using CORE.service;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase

    {
        IIngredientService service;

        public IngredientController(IIngredientService service)
        {
            this.service = service;
        }


        [HttpGet]
        public List<Ingredient> GetAll()
        {
            
            return service.GetAll();
        }


        [HttpPost]
        public void Post( string name)
        {
            service.AddIngredient(name);
        }

      

        
    }
}
