using CORE.service;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        IUserService _userService;


        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        

        [HttpGet("{email}/{password}")]
        public User Get(string email,string password)
        {
            return _userService.GetUser(email, password);

        }

        [HttpGet()]
        public List<User> Get()
        {
            return _userService.GetUsers();

        }


        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userService.AddUser(user);
        }



        //[HttpPost]

        //public void Post(string fname, string lname, string email, string password)
        //{
        //    _userService.AddUser( fname,  lname,  email,  password);
        //}


    }
}
