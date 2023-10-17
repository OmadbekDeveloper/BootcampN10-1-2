using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Photogram.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _userservice;

        public UserController(IUser userservice)
        {
            this._userservice = userservice;
        }

        [HttpGet("GetAllCustomers")]
        public async Task<IEnumerable<User>> GetAllCustomers()
        {
            var customers = await _userservice.GetAllUsersAsync();

            return customers;
        }

        [HttpGet("GetUserId")]
        public async Task<User> GetCustomerId(int id)
        {
            var customer = await _userservice.GetUserByIdAsync(id);

            return customer;
        } // done



        [HttpPost("create")]
        public async Task<IActionResult> CreateUserAsync(User user)
        {
            try
            {
                var createcustomer =  _userservice.CreateUserAsync(user);

                return Ok("created");
            }
            catch (Exception ex)
            {
                // Handle exceptions here, you may want to log the exception
                return StatusCode(500, "An error occurred while creating the user.");
            }
        } // done

    }
}
