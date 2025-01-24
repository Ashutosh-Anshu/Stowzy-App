using user_gateway.Domain.Entities.Roles;

namespace user_gateway.BLL.Application.Services.Account.DTOs
{
    public class OwnerLoginDTO
    {
        public Guid LoginId { get; set; }

        public Guid RoleId { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

        public string ProfileUrl { get; set; }
        public string ProfileUrlPublicId { get; set; }

        public bool IsActive { get; set; } = true;

        public SYS_Role Role { get; set; }

    }


}
