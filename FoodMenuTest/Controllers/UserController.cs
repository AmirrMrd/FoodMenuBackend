using FoodMenuTest.Data.Entities;
using FoodMenuTest.Repository;
using Microsoft.AspNetCore.Mvc;
using FoodMenuTest.Model;
using FoodMenuTest.Helper;

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
        public async Task<ActionResult<LoginResult>> LoginAsync(string email , string password)
        {
            return await _userRepository.LoginAsync(email, password);  
        }

        [HttpPost("Register")]
        public async Task<ActionResult<User>> RegisterAsync([FromBody] User user)
        {

            var newUser = new User();
            newUser.Id = user.Id;
            newUser.firstName = user.firstName;
            newUser.lastName = user.lastName;
            newUser.emailOrMobile = user.emailOrMobile;
            newUser.password = user.password;
            newUser.confirmPassword = user.confirmPassword;

            return await _userRepository.RegisterAsync(newUser);
        }

       
    }
}
