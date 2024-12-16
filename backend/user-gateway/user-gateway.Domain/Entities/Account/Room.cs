using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_gateway.Domain.Entities.Account
{
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoomId { get; set; }

        [Required]
        public required string BusinessName { get; set; }

        [Required]
        public required string BusinessType { get; set; }

        [Required]
        public required int NoOfRooms { get; set; }

        [Required]
        public required string RoomSize { get; set; }

        [Required]
        public required string SecurityMeasures { get; set; }

        [Required]
        public required decimal HourlyRentalPrice { get; set; }

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

        [Required]
        public required string CurrentLocation { get; set; }

        public Guid RoomOwnerId { get; set; }
        public RoomOwner RoomOwner { get; set; } = null!;
    }
}
