using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace user_gateway.Domain.Entities.Roles
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoleId { get; set; }

        [Required]
        public string RoleName { get; set; } 

        public List<RolePermission> RolePermissions { get; set; } 

        public List<MenuRole> MenuRoles { get; set; }

    }


}
