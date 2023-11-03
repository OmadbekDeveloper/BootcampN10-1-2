using N36_HT3.Interface;
using N36_HT3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT3.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> users;

        public UserService()
        {
            users = new List<User>();
        }

        User IUserService.Create(User user)
        {
            User existUser = users.FirstOrDefault(m => m.Id.Equals(user.Id));

            if (existUser != null)
            {
                throw new Exception("User already exists");
            };

            existUser.Id = user.Id;
            existUser.FirstName = user.FirstName;
            existUser.LastName = user.LastName;

            users.Add(user);

            return existUser;
        }

        public User GetById(Guid id)
        {
            User existUseer = users.FirstOrDefault(m => m.Id.Equals(id));

            if (existUseer is null)
                throw new Exception("User is not found");

            return existUseer;
        }

        public IEnumerable<User> GetAll()
        {
            return users;
        }

        User IUserService.Update(User user)
        {
            var existUser = users.FirstOrDefault(u => u.Id == user.Id);

            if (existUser != null)
            {
                existUser.FirstName = user.FirstName;
                existUser.LastName = user.LastName;
            }

            return existUser;
        }

        bool IUserService.Delete(Guid id)
        {
            var existUser = users.FirstOrDefault(u => u.Id == id);

            if (existUser != null)
            {
                users.Remove(existUser);
                return true;
            }

            return false;
        }
    }

}
