using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using user_gateway.BLL.Application.Services.Account;
using user_gateway.BLL.Application.Services.Account.DTOs;
using user_gateway.Common.Responses;
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
        [Route("registerRoomOwner")]
        public async Task<IActionResult> RegisterRoomOwner([FromForm] RegisterRoomOwnerDTO registerRoomOwner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiMessageResponse("Invalid data", false, 400, ModelState));
            }

            var result = await _accountService.RegisterRoomOwner(registerRoomOwner);

            if (!result)
            {
                return StatusCode(500, new ApiMessageResponse("Failed to register room owner", false, 500));
            }

            return Ok(new ApiMessageResponse("Room owner registered successfully", true, 201));
        }
    }
}
