using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using user_gateway.BLL.Application.Services.Account;
using user_gateway.BLL.Application.Services.Account.DTOs;
using user_gateway.Domain.Entities;

namespace user_gateway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : BaseApiController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        [HttpPost]
        [Route("roomOwnerRegistration")]
        public async Task<IActionResult> RoomOwnerRegistration([FromForm] RoomOwnerRegistrationDTO roomOwnerRegistration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            
            return Ok("Data received successfully");
        }
    }
}
