using Application.DTOs.Request;
using Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticateService _authenticateService;
        public AuthenticateController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var token = await _authenticateService.Authenticate(loginDTO);
            return Ok(token);
        }
    }
}
