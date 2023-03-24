using FoodMenuTest.Data.Entities;
using FoodMenuTest.Model;

namespace FoodMenuTest.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task <User?> GetUserByIdAsync(int Id);
        Task<User> RegisterAsync(User newUser);
        
        Task<LoginResult> LoginAsync (string email , string password);
    }
}
