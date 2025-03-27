using Application.DTOs.Request;
using Application.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;    
        }
        [HttpPost("sign-up")]
        public async Task<IActionResult> CreateAccount(RegisterDTO dto)
        {
            await _accountService.CreateAccount(dto);
            return Ok();
        }
    }
}
