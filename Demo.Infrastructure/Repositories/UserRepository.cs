using Demo.Domain.Enitities;
using Demo.Domain.Interface;
using Demo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _dbContext;
        public UserRepository(DatabaseContext databaseContext)
        {
            _dbContext = databaseContext;
        }
        public async Task<User> GetUserByUsernameAndPassword(string username, string password)
        {
            return await _dbContext.Users
                        .Where(u => u.Username == username && u.Password == password)
                        .FirstOrDefaultAsync();

           
        }
    }
}
