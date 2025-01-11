using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_gateway.BLL.Application.Services.Account.DTOs;
using user_gateway.Common.Helpers;
using user_gateway.Domain.Entities.Account;

namespace user_gateway.BLL.Application.Services.Account
{
    public interface IAccountService
    {
        Task<ApiMessageResponse> RegisterOwner(RegisterOwnerDTO registerOwner);
    }
}
