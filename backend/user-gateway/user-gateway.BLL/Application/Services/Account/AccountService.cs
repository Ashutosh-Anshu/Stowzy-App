using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_gateway.BLL.Application.Helpers;
using user_gateway.BLL.Application.Services.Account.DTOs;
using user_gateway.DAL.Infrastructure.Repositories.Account;
using user_gateway.Domain.Entities.Account;

namespace user_gateway.BLL.Application.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly IMapper _mapper;
        private readonly IAccountRepository _accountRepository;
        private readonly ICloudinaryService _cloudinaryService;

        private string RoomOwnerProfiles = "RoomOwnerProfiles";

        public AccountService(
            IMapper mapper,
            IAccountRepository accountRepository,
            ICloudinaryService cloudinaryService
           )
        {
            _mapper = mapper;
            _accountRepository = accountRepository;
            _cloudinaryService = cloudinaryService;
        }

        public async Task<bool> RegisterRoomOwner(RegisterRoomOwnerDTO registerRoomOwner)
        {
            try
            {
                if (registerRoomOwner.roomOwner != null)
                {
                    if(registerRoomOwner.roomOwner.ProfileImage != null)
                    {
                        var file = registerRoomOwner.roomOwner.ProfileImage;
                        var result = await _cloudinaryService.UploadFileAsync(file, RoomOwnerProfiles); 
                    }
                }
              
            }
            catch (Exception)
            {
               
            }

            return await Task.FromResult(false);
        }
    }
}
