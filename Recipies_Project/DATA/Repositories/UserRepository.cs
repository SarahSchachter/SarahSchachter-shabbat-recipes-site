using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entities;

namespace CORE.repositories
{
    public class UserRepository:IUserRepository
    {
        DataContex _contex;

        public UserRepository(DataContex contex) { _contex = contex; }
        public User GetUser(string email, string password)
        {
            return _contex.Users.FirstOrDefault(u=> u.Password == password && u.Email==email);
        }
        //public void AddUser(string fname, string lname, string email, string password)
        //{
        //    var newUser = new User
        //    {
        //        Id = _contex.Users.Count() + 1,
        //        Fname = fname,
        //        Email = email,
        //        Password = password,
        //        Lname = lname
        //    };

        //    _contex.Users.Add(newUser);
        //    _contex.SaveChanges();

        //}

        public void AddUser(User user)
        {
            user.Id = _contex.Users.Count() + 1; 
            _contex.Users.Add(user);
            _contex.SaveChanges();
        }


        public List<User> GetAll()
        {
            return _contex.Users.ToList();
        }

    }
}
