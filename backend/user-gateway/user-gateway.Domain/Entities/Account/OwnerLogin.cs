using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using user_gateway.Domain.Entities.Roles;

namespace user_gateway.Domain.Entities.Account
{

    public class OwnerLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LoginId { get; set; }


        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public string ProfileUrl { get; set; }
        public string ProfileUrlPublicId { get; set; }

        public bool IsActive { get; set; } = true;

        // Relationships

        public Guid OwnerId { get; set; }
        public Owner Owner { get; set; } = null!;

        public Guid RoleId { get; set; }
        public Role Role { get; set; } = null!;


    }


}
