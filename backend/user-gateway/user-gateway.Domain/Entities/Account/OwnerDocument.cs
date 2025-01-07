using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace user_gateway.Domain.Entities.Account
{

    public class OwnerDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DocumentId { get; set; }

        [Required]
        public string DocumentProofType { get; set; }

        [Required]
        public string DocumentPublicId { get; set; }

        [Required]
        public string DocumentUrl { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;

        // Relationships
        public Guid OwnerId { get; set; }

        public Owner Owner { get; set; } = null!;


    }

}
