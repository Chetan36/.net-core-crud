using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface UserService
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        Task<User> AddNewUser(User user);
        Task<User> UpdateUserById(int id, User user);
        Task<User> DeleteUserById(int id);
    }
}
