using System.ComponentModel.DataAnnotations;

namespace user_gateway.Domain.Entities.Account
{
    public class RoomOwnerLogin
    {
        [Key]
        public Guid LoginId { get; set; }

        public Guid RoomOwnerId { get; set; }
        public RoomOwner RoomOwner { get; set; } = null!;

        [Required]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public bool? IsActive { get; set; } = true;

        [Required]
        public DateTime CreatedDate { get; set; }

        public Guid RoleId { get; set; }
    }
}
