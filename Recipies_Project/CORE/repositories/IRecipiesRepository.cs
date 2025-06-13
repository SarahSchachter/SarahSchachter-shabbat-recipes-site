using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebApi.Entities;

namespace CORE.repositories
{
    public interface IRecipiesRepository
    {
        List<Recipe> GetAll() ;
        Recipe GetById(int id);
        Recipe AddRecipe(Recipe recipe);

    }
}
