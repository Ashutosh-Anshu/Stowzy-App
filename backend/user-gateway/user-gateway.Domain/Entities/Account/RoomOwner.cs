using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_gateway.Domain.Entities.Account
{
    public class RoomOwner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoomOwnerId { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string FirstName { get; set; }

        public string? LastName { get; set; }

        [Required]
        public required DateTime DateOfBirth { get; set; }

        [Required]
        public required string Gender { get; set; }

        public string? SecondaryNumber { get; set; }

        [Required]
        public required DateTime ModifiedDate { get; set; }

        [Required]
        public required bool IsDeleted { get; set; } = false;

        [Required]
        public required string StreetAddress { get; set; }

        public string? Landmark { get; set; }

        [Required]
        public required string Country { get; set; }

        [Required]
        public required string State { get; set; }

        [Required]
        public required string City { get; set; }

        [Required]
        public required string PostalCode { get; set; }

        public string? ProfileImagePath { get; set; }
        public string? Role { get; set; }

        public List<Room>? Rooms { get; set; } 
        public RoomOwnerLogin? RoomOwnerLogin { get; set; }
        public List<StowzyDocument>? StowzyDocuments { get; set; } 
    }
}
