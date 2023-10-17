using Microsoft.EntityFrameworkCore;

namespace Photogram.Service
{
    public class UserService : IUser
    {
        private readonly PhotogramDB _context;

        public UserService(PhotogramDB context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            try
            {
                var getAllCustomers = await _context.Users.ToListAsync();
                return getAllCustomers;
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                return null;
            }
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            try
            {
                var getCustomerById = await _context.Users.FirstOrDefaultAsync(x => x.UserId == id);
                return getCustomerById;
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                return null;
            }
        }

        public async Task CreateUserAsync(User user)
        {
            try
            {
                var usercreate = new User()
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password,
                    
                };
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Handle exceptions here
            }
        }
    }
}
