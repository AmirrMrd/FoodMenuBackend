using FoodMenuTest.Data.Entities;
using FoodMenuTest.Model;

namespace FoodMenuTest.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUserAsync();
        Task <User?> GetUserByIdAsync(int Id);
        Task<User> SaveUserAsync(User newUser);
        
        Task<LoginResult> LoginUserAsync (string email , string password);
    }
}
