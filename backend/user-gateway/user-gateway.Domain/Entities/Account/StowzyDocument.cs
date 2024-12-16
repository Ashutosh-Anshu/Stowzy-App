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
    public class StowzyDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DocumentId { get; set; }

        [Required]
        public required string IdentityProofType { get; set; }

        [Required]
        public required IFormFile IdentityProofDocument { get; set; }

        [Required]
        public required List<IFormFile> StowzyImages { get; set; }

        public Guid RoomOwnerId { get; set; }
        public RoomOwner RoomOwner { get; set; } = null!;
    }
}
