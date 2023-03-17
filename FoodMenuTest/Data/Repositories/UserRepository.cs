
using FoodMenuTest.Data.Entities;
using FoodMenuTest.Model;
using FoodMenuTest.Repository;
using Microsoft.EntityFrameworkCore;

namespace FoodMenuTest.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly foodMenuContext _context;

        public UserRepository(foodMenuContext context)
        {
            _context = context;
        }



        public async Task<IEnumerable<User>> GetAllUserAsync()
        => await _context.Users.ToListAsync();


        public async Task<User?> GetUserByIdAsync(int Id)
        => await _context.Users.FirstOrDefaultAsync(u => u.Id == Id);

        public async Task<User> SaveUserAsync(User newUser)
        {
            await _context.Users.AddAsync(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }

        public async Task<LoginResult> LoginUserAsync(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.emailOrMobile == email && x.password == password);
            if (user == null)
            {
                return LoginResult.UserNotFound;
            }
            else
            {
                return LoginResult.success;
            }
        }
           



    }
}
