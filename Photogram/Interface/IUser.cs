namespace Photogram.Interface
{
    public interface IUser
    {
        public Task<IEnumerable<User>> GetAllUsersAsync();
        public Task<User> GetUserByIdAsync(int id);
        public Task CreateUserAsync(User user);
    }
}
