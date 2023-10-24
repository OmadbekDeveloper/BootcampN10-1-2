using UsingMapSter.Entites;
using UsingMapSter.DTos;
using Mapster;
using UsingMapSter.DTos;
namespace UsingMapSter
{
    public class UserService
    {
        private IList<User> _users = new List<User>();

        public User Create(UserForCreation userForCreation)
        {
            var existUser = _users.FirstOrDefault(u => u.Email.Equals(userForCreation.Email));
            if (existUser != null)
            {
                Console.WriteLine("Bu User mavjud");
                return existUser;
            }

            var newUser = userForCreation.Adapt<User>();

            newUser.CreatedAt = DateTime.UtcNow;
            newUser.UpdatedAt = DateTime.UtcNow;

            _users.Add(newUser);

            return newUser;
        }

        public List<UserViewModel> GetUsers()
        {
            return _users.Adapt<List<UserViewModel>>();
        }
    }
}
