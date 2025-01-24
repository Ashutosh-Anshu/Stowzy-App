using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_gateway.BLL.Application.Services.Account.DTOs
{
    public class OwnerDTO
    {
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string SecondaryNumber { get; set; }
        public string StreetAddress { get; set; }
        public string Landmark { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Password { get; set; }
        public string LevelType { get; set; }
        public Guid RoleId { get; set; }

        [NotMapped]
        public IFormFile ProfileImage { get; set; }
    }


}
