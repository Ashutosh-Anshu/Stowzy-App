using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_gateway.Domain.Entities.Roles;

namespace user_gateway.Domain.Entities.Account
{

    public class Owner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; }

        public string SecondaryNumber { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        public string Landmark { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Required]
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;

        [Required]
        public bool IsDeleted { get; set; } = false;

        public List<Locker> Lockers { get; set; } = new List<Locker>();

        public OwnerDocument OwnerDocument { get; set; } = null!;


    }


}
