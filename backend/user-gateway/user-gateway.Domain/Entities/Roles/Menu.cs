using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace user_gateway.Domain.Entities.Roles
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MenuId { get; set; }

        [Required]
        [StringLength(50)]
        public required string MenuName { get; set; }

        public string? Url { get; set; }

        public string? Icon { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;

        public List<MenuRole>? MenuRoles { get; set; }
    }

    
}
