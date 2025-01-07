using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_gateway.BLL.Application.Services.Account.DTOs
{

    public class LockerDocumentDTO
    {
        public Guid DocumentId { get; set; }

        public string DocumentProofType { get; set; }

        [NotMapped]
        public IFormFile DocumentProofFile { get; set; }
        public string DocumentPublicId { get; set; }
        public string DocumentUrl { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;

        [NotMapped]
        public List<IFormFile> LockerImages { get; set; } = new List<IFormFile>();

    }


}
