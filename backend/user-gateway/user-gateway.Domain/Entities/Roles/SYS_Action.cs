using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_gateway.Domain.Entities.Roles
{

    public class SYS_Action
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ActionId { get; set; }

        public Guid MenuId { get; set; }
        public SYS_Menu Menu { get; set; }

        public string ActionName { get; set; } // e.g., "Create", "Edit", "Delete", "View", "Comment"
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }


}
