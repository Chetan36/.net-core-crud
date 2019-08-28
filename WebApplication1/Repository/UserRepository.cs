using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public interface UserRepository
    {
        Task<List<User>> FindAll();
        Task<User> FindById(int id);
        Task<User> Create(User user);
        Task<User> Update(int id, User user);
        Task<User> Delete(int id);
    }
}
