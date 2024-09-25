using Demo.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Services
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
