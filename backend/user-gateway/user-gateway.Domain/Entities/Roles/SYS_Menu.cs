using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace user_gateway.Domain.Entities.Roles
{
    public class SYS_Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid MenuId { get; set; }

        public required string MenuName { get; set; }
        public string Icon { get; set; }
        public Guid? ParentId { get; set; }
        public SYS_Menu SYS_ParentMenu { get; set; }
        public ICollection<SYS_Menu> SYS_Menus { get; set; } = new List<SYS_Menu>();

        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
        public int OrderNum { get; set; }
        public string LevelType { get; set; } 
    }

}
