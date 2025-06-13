using CORE.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.service
{
    public class UserService:IUserService
    {
        IUserRepository _repository;

        public UserService(IUserRepository repository)
        { _repository = repository; }
       public User GetUser(string email, string password)
        {
          return  _repository.GetUser(email, password);

        }
        //public void AddUser(string fname, string lname, string email, string password)
        //{
        //    _repository.AddUser(fname, lname, email, password);
        //}

        public void AddUser(User user)
        {
            _repository.AddUser(user);
        }

        public List<User> GetUsers()
        {
            return _repository.GetAll();
        }

      
    }
}
