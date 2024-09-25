using Demo.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            string token = await _userService.Login(username, password);

            if (token == null)
            {
                return Unauthorized("Invalid username or password.");
            }

            return Ok(token);
        }
    }
}
