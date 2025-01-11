using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using user_gateway.BLL.Application.Services.Account;
using user_gateway.BLL.Application.Services.Account.DTOs;
using user_gateway.Common.Helpers;

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
        [Route("registerOwner")]
        public async Task<IActionResult> RegisterOwner([FromForm] RegisterOwnerDTO registerOwner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiMessageResponse("Invalid data", false, 400, ModelState));
            }

            var result = await _accountService.RegisterOwner(registerOwner);

            return Ok(result);
        }
    }
}
