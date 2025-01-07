using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace user_gateway.Domain.Entities.Roles
{
    public class MenuRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MenuRoleId { get; set; }

        [Required]
        public Guid MenuId { get; set; }
        public Menu? Menu { get; set; }

        [Required]
        public Guid RoleId { get; set; }
        public Role? Role { get; set; }
    }


}
