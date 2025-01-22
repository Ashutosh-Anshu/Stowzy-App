using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace user_gateway.Domain.Entities.Roles
{
    public class SYS_Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoleId { get; set; }

        public string RoleName { get; set; }
        public string RoleType { get; set; }
        public string RoleDesc { get; set; }

        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public string LevelType { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

        public ICollection<SYS_ActionInRole> SYS_ActionInRole { get; set; } = new List<SYS_ActionInRole>();
    }



}
