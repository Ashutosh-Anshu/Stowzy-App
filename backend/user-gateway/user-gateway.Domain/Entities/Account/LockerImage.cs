using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_gateway.Domain.Entities.Account
{
    public class LockerImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LockerImageId { get; set; }

        [Required]
        public string LockerImagePublicId { get; set; }

        [Required]
        public string LockerImageUrl { get; set; }
        public bool IsPrimary { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime? ModifiedDate { get; set; } = DateTime.UtcNow;

        // Relationships

        public Guid LockerId { get; set; }
        public Locker Locker { get; set; } = null!;
    }


}
