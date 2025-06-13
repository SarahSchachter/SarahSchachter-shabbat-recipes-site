using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.repositories
{
    public interface IUserRepository
    {
        User GetUser(string email, string password);
        //void AddUser(string fname,string lname, string email, string password);

        public void AddUser(User user);
   
            List<User> GetAll();

    }
}
