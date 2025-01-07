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

        private string OwnerProfiles = "OwnerProfiles";

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

        public async Task<bool> RegisterOwner(RegisterOwnerDTO registerOwner)
        {
            try
            {
                var ownerLoginDTO = new OwnerLoginDTO()
                {
                    Email = registerOwner.Owner?.Email,
                    PhoneNumber = registerOwner.Owner?.PhoneNumber,
                    PasswordHash = registerOwner.Owner?.Password,
                    
                };

                registerOwner.OwnerLogin = ownerLoginDTO;


                if (registerOwner.Owner != null)
                {
                    if (registerOwner.Owner.ProfileImage != null)
                    {
                        var file = registerOwner.Owner.ProfileImage;
                        var result = await _cloudinaryService.UploadFileAsync(file, OwnerProfiles);

                        if (result != null)
                        {
                            ownerLoginDTO.ProfileUrl = result?.SecureUri.AbsoluteUri;
                            ownerLoginDTO.ProfileUrlPublicId = result?.PublicId;
                        }

                    }
                }


                if (registerOwner.LockerDocument != null)
                {
                    if (registerOwner.LockerDocument.DocumentProofFile != null)
                    {
                        var file = registerOwner.LockerDocument.DocumentProofFile;
                        var result = await _cloudinaryService.UploadFileAsync(file, OwnerProfiles);

                        if (result != null)
                        {
                            registerOwner.LockerDocument.DocumentUrl = result?.SecureUri.AbsoluteUri;
                            registerOwner.LockerDocument.DocumentPublicId = result?.PublicId;
                        }
                    }

                    if (registerOwner.LockerDocument.LockerImages != null)
                    {
                        var files = registerOwner.LockerDocument.LockerImages;                     

                        foreach (var file in files)
                        {
                            var lockerImage = new LockerImageDTO();
                            var result = await _cloudinaryService.UploadFileAsync(file, OwnerProfiles);
                            if (result != null)
                            {
                                lockerImage.LockerImageUrl = result?.SecureUri.AbsoluteUri;
                                lockerImage.LockerImagePublicId = result?.PublicId;
                            }
                            registerOwner.Locker.LockerImages.Add(lockerImage);

                        }

                    }

                }

                var result1 = _mapper.Map<RegisterOwnerModel>(registerOwner);


            }
            catch (Exception)
            {

            }

            return await Task.FromResult(false);
        }


    }

}
