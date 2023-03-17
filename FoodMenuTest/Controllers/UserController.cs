using FoodMenuTest.Data.Entities;
using FoodMenuTest.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using FoodMenuTest.Model;

namespace FoodMenuTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController (IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userRepository.GetAllUserAsync();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<User?> GetUserByIdAsync(int Id)
        {
            return await _userRepository.GetUserByIdAsync(Id);
        }

        [HttpGet("{email}/{password}")]
        public async Task<ActionResult<LoginResult>> LoginUserAsync(string email , string password)
        {
            return await _userRepository.LoginUserAsync(email, password);  
        }

        [HttpPost]
        public async Task<ActionResult<User>> saveUser (User user)
        {

            var newUser = new User();
            newUser.Id = user.Id;
            newUser.firstName = user.firstName;
            newUser.lastName = user.lastName;
            newUser.emailOrMobile = user.emailOrMobile;
            newUser.password = user.password;
            newUser.confirmPassword = user.confirmPassword;

            return await _userRepository.SaveUserAsync(newUser);
        }
    }
}
