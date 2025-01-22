using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace user_gateway.Domain.Entities.Roles
{
    public class SYS_ActionInRole
    {
        public Guid RoleId { get; set; }
        public SYS_Role SYS_Role { get; set; }

        public Guid ActionId { get; set; }
        public SYS_Action SYS_Action { get; set; }
    }

}
