using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_gateway.Domain.Entities.Roles
{

    public class Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PermissionId { get; set; }

        [Required]
        public string? PermissionName { get; set; } // e.g., "Create", "Edit", "Delete", "View", "Comment"

        [Required]
        public string? Description { get; set; }

        public List<RolePermission>? RolePermissions { get; set; }
    }

}
