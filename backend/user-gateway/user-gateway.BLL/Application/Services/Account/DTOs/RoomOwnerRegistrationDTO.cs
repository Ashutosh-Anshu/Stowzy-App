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
        public Guid RoomOwnerId { get; set; }
        public required string Title { get; set; }
        public required string FirstName { get; set; }
        public string? LastName { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string Gender { get; set; }
        public required string PhoneNumber { get; set; }
        public string? SecondaryNumber { get; set; }
        public required string Email { get; set; }
        public required bool IsActive { get; set; }
        public required DateTime CreatedDate { get; set; }
        public required DateTime ModifiedDate { get; set; }
        public required bool IsDeleted { get; set; }
        public required string StreetAddress { get; set; }
        public string? Landmark { get; set; }
        public required string Country { get; set; }
        public required string State { get; set; }
        public required string City { get; set; }
        public required string PostalCode { get; set; }
        public IFormFile? ProfileImage { get; set; }
        public string? Role { get; set; }
    }


    public class RoomDTO
    {
        public Guid RoomId { get; set; }
        public required string BusinessName { get; set; }
        public required string BusinessType { get; set; }
        public required int NoOfRooms { get; set; }
        public required string RoomSize { get; set; }
        public required string SecurityMeasures { get; set; }
        public required decimal HourlyRentalPrice { get; set; }
        public required string StreetAddress { get; set; }
        public string? Landmark { get; set; }
        public required string Country { get; set; }
        public required string State { get; set; }
        public required string City { get; set; }
        public required string PostalCode { get; set; }
        public required string CurrentLocation { get; set; }
    }

    public class StowzyDocumentsDTO
    {
        public Guid DocumentId { get; set; }
        public required string IdentityProofType { get; set; }
        public required IFormFile IdentityProofDocument { get; set; }
        public required List<IFormFile> StowzyImages { get; set; } = new List<IFormFile>();
    }
}
