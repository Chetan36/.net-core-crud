using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Repository.RepositoryImpl
{
    public class UserRepositoryImpl : UserRepository
    {
        private WebApplication1Context _dbcontext;

        public UserRepositoryImpl(WebApplication1Context context)
        {
            _dbcontext = context;
        }

        public async Task<User> Create(User user)
        {
            var result = await _dbcontext.Users.AddAsync(user);
            var savedResult = await _dbcontext.SaveChangesAsync();
            return user;
        }

        public async Task<User> Delete(int id)
        {
            var dbUser = await _dbcontext.Users.SingleOrDefaultAsync(o => o.Id == id);
            _dbcontext.Users.Remove(dbUser);
            await _dbcontext.SaveChangesAsync();
            return dbUser;
        }

        public async Task<List<User>> FindAll()
        {
            return await _dbcontext.Users.ToListAsync();
        }

        public async Task<User> FindById(int id)
        {
            return await _dbcontext.Users.SingleOrDefaultAsync(o => o.Id == id);
        }

        public async Task<User> Update(int id, User user)
        {
            var dbUser = _dbcontext.Users.SingleOrDefault(o => o.Id == id);
            if (dbUser.Name != user.Name)
            {
                dbUser.Name = user.Name;
            }
            if (dbUser.Age != user.Age)
            {
                dbUser.Age = user.Age;
            }
            var result = await _dbcontext.SaveChangesAsync();
            return dbUser;
        }
    }
}
