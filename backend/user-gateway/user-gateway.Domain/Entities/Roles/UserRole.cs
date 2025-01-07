using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using user_gateway.Domain.Entities.Account;

namespace user_gateway.Domain.Entities.Roles
{
    public class UserRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserRoleId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid RoleId { get; set; }

        public Role? Role { get; set; }
    }



}
