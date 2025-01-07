using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace user_gateway.Domain.Entities.Roles
{
    public class RolePermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RolePermissionId { get; set; }

        [Required]
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }

        [Required]
        public Guid PermissionId { get; set; }
        public Permission? Permission { get; set; }
    }


}
