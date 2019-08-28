using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Services.ServiceImplementations
{
    public class UserServiceImpl : UserService
    {
        private readonly UserRepository _userrepository;

        public UserServiceImpl(UserRepository userRepository)
        {
            _userrepository = userRepository;
        }

        public async Task<User> AddNewUser(User user)
        {
            return await _userrepository.Create(user);
        }

        public async Task<User> DeleteUserById(int id)
        {
            return await _userrepository.Delete(id);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userrepository.FindAll();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userrepository.FindById(id);
        }

        public async Task<User> UpdateUserById(int id, User user)
        {
            return await _userrepository.Update(id, user);
        }
    }
}
