using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_gateway.Domain.Entities.Account
{
    public class Locker
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LockerId { get; set; }

        [Required]
        public string BusinessName { get; set; }

        [Required]
        public string BusinessType { get; set; }

        [Required]
        public long NoOfLockers { get; set; }

        [Required]
        public string LockerSize { get; set; }

        [Required]
        public string SecurityMeasures { get; set; }

        [Required]
        public decimal HourlyRentalPrice { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        public string Landmark { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string CurrentLocation { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;

        // Relationships
        public Guid OwnerId { get; set; }

        public Owner Owner { get; set; } = null!;

        public List<LockerImage> LockerImages { get; set; } = new List<LockerImage>();

    }

}
