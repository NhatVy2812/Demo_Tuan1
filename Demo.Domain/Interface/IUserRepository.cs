using Demo.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsernameAndPassword(string username, string password);
    }
}
