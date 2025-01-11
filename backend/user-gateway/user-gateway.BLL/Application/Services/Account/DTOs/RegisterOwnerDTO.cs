using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_gateway.Domain.Entities.Account;

namespace user_gateway.BLL.Application.Services.Account.DTOs
{
    public class RegisterOwnerDTO
    {
        public LockerDTO Locker { get; set; }
        public OwnerDTO Owner { get; set; }
        public OwnerLoginDTO OwnerLogin { get; set; }
        public LockerDocumentDTO LockerDocument { get; set; }
    }


}