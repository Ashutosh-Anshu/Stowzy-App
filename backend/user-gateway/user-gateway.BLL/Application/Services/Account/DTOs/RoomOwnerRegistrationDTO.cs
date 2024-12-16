using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_gateway.BLL.Application.Services.Account.DTOs
{
    public class RoomOwnerRegistrationDTO
    {
        public RoomOwnerDTO? roomOwner { get; set; }
        public RoomDTO? room { get; set; }
        public StowzyDocumentsDTO? stowzyDocuments { get; set; }
    }

    public class RoomOwnerDTO
    {
        public Guid? RoomOwnerId { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? SecondaryNumber { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
        public bool IsDeleted { get; set; } = false;
        public string? StreetAddress { get; set; }
        public string? Landmark { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public IFormFile? ProfileImage { get; set; }
        public string? Role { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; }

    }

    public class RoomDTO
    {
        public Guid RoomId { get; set; }
        public string? BusinessName { get; set; }
        public string? BusinessType { get; set; }
        public int? NoOfRooms { get; set; }
        public string? RoomSize { get; set; }
        public string? SecurityMeasures { get; set; }
        public decimal? HourlyRentalPrice { get; set; }
        public string? StreetAddress { get; set; }
        public string? Landmark { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? CurrentLocation { get; set; }
    }

    public class StowzyDocumentsDTO
    {
        public Guid DocumentId { get; set; }
        public string? IdentityProofType { get; set; }
        public IFormFile? IdentityProofDocument { get; set; }
        public List<IFormFile> StowzyImages { get; set; } = new List<IFormFile>();
    }
    
}