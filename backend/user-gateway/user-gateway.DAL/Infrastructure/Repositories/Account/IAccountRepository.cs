using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_gateway.Common.Helpers;
using user_gateway.Domain.Entities.Account;
using user_gateway.Domain.Entities.Roles;

namespace user_gateway.DAL.Infrastructure.Repositories.Account
{
    public interface IAccountRepository
    {
        Task<ApiMessageResponse> RegisterOwner(RegisterOwnerModel registerOwner);
        Task<SYS_Role> GetRoleByLevel(string levelType);
    }
}
