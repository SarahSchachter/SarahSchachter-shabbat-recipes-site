using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.service
{
    public interface IUserService
    {
        User GetUser(string email, string password);
        //void AddUser(string fname, string lname, string email, string password);

        public void AddUser(User user);
       
            List<User> GetUsers();
    }
}
