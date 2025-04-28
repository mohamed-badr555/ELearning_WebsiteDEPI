using BLL.DTOs.AccountDTOs;
using BLL.Managers.AccountManager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountManager _account;
        public AccountController(IAccountManager account)
        {
            _account = account;
        }

        [HttpPost("Login")]
        public async Task<ActionResult> Login(LogInDto logInDto)
        {
            var result =  await _account.Login(logInDto);

            if(result == null)
            {
                return Unauthorized("Invalid username or password");
            }
            return Ok(result);
        }

        [HttpPost("Register")]
        public async Task<ActionResult> Register(RegisterDto registerInDto)
        {
            var result = await _account.Register(registerInDto);

            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
