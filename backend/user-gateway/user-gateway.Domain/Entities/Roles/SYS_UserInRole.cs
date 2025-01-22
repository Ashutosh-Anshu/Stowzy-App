using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using user_gateway.Domain.Entities.Account;

namespace user_gateway.Domain.Entities.Roles
{
    public class SYS_UserInRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public SYS_Role SYS_Role { get; set; }
        public string LevelType { get; set; }
    }

}
