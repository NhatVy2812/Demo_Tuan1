using Demo.Domain.Enitities;
using Demo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public UserService(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }
        public async Task<string> Login(string username, string password)
        {
            var user = await _userRepository.GetUserByUsernameAndPassword(username, password);

            if (user == null)
            {
                return null; 
            }
            var token = _tokenService.GenerateToken(user);

            return token;
        }
    }
}
