using AutoMapper;
using System;
using user_gateway.BLL.Application.Helpers;
using user_gateway.BLL.Application.Services.Account.DTOs;
using user_gateway.Common.Helpers;
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

        public async Task<ApiMessageResponse> RegisterOwner(RegisterOwnerDTO registerOwner)
        {
            try
            {
                string salt = PasswordService.GenerateSalt();
                string hashedPassword = PasswordService.HashPassword(registerOwner.Owner?.Password, salt);

                var ownerLoginDTO = new OwnerLoginDTO()
                {
                    Email = registerOwner.Owner?.Email,
                    PhoneNumber = registerOwner.Owner?.PhoneNumber,
                    PasswordHash = hashedPassword,
                    PasswordSalt = salt

                };

                registerOwner.OwnerLogin = ownerLoginDTO;

                if (registerOwner.Owner != null)
                {
                    if (registerOwner.Owner.ProfileImage != null)
                    {
                        var file = registerOwner.Owner.ProfileImage;
                        //var result = await _cloudinaryService.UploadFileAsync(file, OwnerProfiles);

                        //if (result != null)
                        //{
                        //    ownerLoginDTO.ProfileUrl = result?.SecureUri.AbsoluteUri;
                        //    ownerLoginDTO.ProfileUrlPublicId = result?.PublicId;
                        //}

                        ownerLoginDTO.ProfileUrl = "https://storage.example.com/lockers/locker1.jpg";
                        ownerLoginDTO.ProfileUrlPublicId = "locker_images/locker1";

                    }
                }

                if (registerOwner.LockerDocument != null)
                {
                    if (registerOwner.LockerDocument.DocumentProofFile != null)
                    {
                        var file = registerOwner.LockerDocument.DocumentProofFile;
                        //var result = await _cloudinaryService.UploadFileAsync(file, OwnerProfiles);

                        //if (result != null)
                        //{
                        //    registerOwner.LockerDocument.DocumentUrl = result?.SecureUri.AbsoluteUri;
                        //    registerOwner.LockerDocument.DocumentPublicId = result?.PublicId;
                        //}

                        registerOwner.LockerDocument.DocumentUrl = "https://storage.example.com/lockers/locker1.jpg";
                        registerOwner.LockerDocument.DocumentPublicId = "locker_images/locker1";
                    }

                    if (registerOwner.LockerDocument.LockerImages != null)
                    {
                        var files = registerOwner.LockerDocument.LockerImages;

                        foreach (var file in files)
                        {
                            var lockerImage = new LockerImageDTO();

                            //var result = await _cloudinaryService.UploadFileAsync(file, OwnerProfiles);
                            //if (result != null)
                            //{
                            //    lockerImage.LockerImageUrl = result?.SecureUri.AbsoluteUri;
                            //    lockerImage.LockerImagePublicId = result?.PublicId;
                            //}

                            lockerImage.LockerImageUrl = "https://storage.example.com/lockers/locker1.jpg";
                            lockerImage.LockerImagePublicId = "locker_images/locker1";

                            registerOwner.Locker.LockerImages.Add(lockerImage);

                        }

                    }

                }

                var result = _mapper.Map<RegisterOwnerModel>(registerOwner);
                var response = await _accountRepository.RegisterOwner(result);
                return await Task.FromResult(response);

            }
            catch (Exception ex)
            {
                return new ApiMessageResponse(ex.Message, false, 500);
            }

        }

    }

}
