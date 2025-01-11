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
            try
            {
                using (var connection = _dataContext.Database.GetDbConnection())
                {
                    await connection.OpenAsync();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "RegisterOwner";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@Locker", JsonConvert.SerializeObject(registerOwner.Locker)));
                        command.Parameters.Add(new SqlParameter("@Owner", JsonConvert.SerializeObject(registerOwner.Owner)));
                        command.Parameters.Add(new SqlParameter("@OwnerLogin", JsonConvert.SerializeObject(registerOwner.OwnerLogin)));
                        command.Parameters.Add(new SqlParameter("@OwnerDocument", JsonConvert.SerializeObject(registerOwner.OwnerDocument)));

                        var result = await command.ExecuteNonQueryAsync();

                        return new ApiMessageResponse(result.ToString(), true, 200);

                    }
                }
            }
            catch (Exception ex)
            {
                return new ApiMessageResponse($"Error: {ex.Message}", false, 500);
            }
        }



    }

}
