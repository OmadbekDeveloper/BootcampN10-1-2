using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N36_HT3.Models;
namespace N36_HT3.Interface
{
    public interface IUserService
    {
        User Create(User user);
        User GetById(Guid id);
        IEnumerable<User> GetAll();
        User Update(User user);
        bool Delete(Guid id);
    }
}
