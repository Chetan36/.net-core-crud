using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userservice;

        public UserController(UserService userservice)
        {
            _userservice = userservice;
        }

        // Get operation for fetching all users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _userservice.GetAllUsers();
        }

        // Post operation for adding a new user
        [HttpPost]
        public async Task<ActionResult<User>> AddNewUser([FromBody] User user)
        {
            return await _userservice.AddNewUser(user);
        }

        // Get operation for fetching user by id
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            return await _userservice.GetUserById(id);
        }

        // Put operation for updating user by id
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUserById(int id, [FromBody] User user)
        {
            return await _userservice.UpdateUserById(id, user);
        }

        // Delete operation for removing a user by id
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUserById(int id)
        {
            return await _userservice.DeleteUserById(id);
        }
    }
}