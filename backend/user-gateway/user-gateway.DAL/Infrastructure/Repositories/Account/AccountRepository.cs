using Azure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_gateway.Common.Helpers;
using user_gateway.DAL.Infrastructure.Persistence;
using user_gateway.Domain.Entities.Account;

namespace user_gateway.DAL.Infrastructure.Repositories.Account
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _dataContext;

        public AccountRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<ApiMessageResponse> RegisterOwner(RegisterOwnerModel registerOwner)
        {

            using var transaction = await _dataContext.Database.BeginTransactionAsync();

            try
            {

                await _dataContext.Owners.AddAsync(registerOwner.Owner);
                await _dataContext.SaveChangesAsync();

                registerOwner.OwnerLogin.OwnerId = registerOwner.Owner.OwnerId;
                registerOwner.OwnerDocument.OwnerId = registerOwner.Owner.OwnerId;
                registerOwner.Locker.OwnerId = registerOwner.Owner.OwnerId;

                await _dataContext.OwnerLogins.AddAsync(registerOwner.OwnerLogin);
                await _dataContext.OwnerDocuments.AddAsync(registerOwner.OwnerDocument);
                await _dataContext.Lockers.AddAsync(registerOwner.Locker);

                foreach (var lockerImage in registerOwner.LockerImages)
                {
                    lockerImage.LockerId = registerOwner.Locker.LockerId;
                }
                await _dataContext.LockerImages.AddRangeAsync(registerOwner.LockerImages);

                await _dataContext.SaveChangesAsync();
                await transaction.CommitAsync();

                return new ApiMessageResponse("Owner registered successfully.", true, 200);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                return new ApiMessageResponse($"Error: {ex.Message}", false, 500);
            }
        }




    }

}
