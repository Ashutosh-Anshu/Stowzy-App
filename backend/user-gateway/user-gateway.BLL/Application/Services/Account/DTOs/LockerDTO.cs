using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_gateway.Domain.Entities.Account;

namespace user_gateway.BLL.Application.Services.Account.DTOs
{


    public class LockerDTO
    {
        public Guid LockerId { get; set; }
        public string BusinessName { get; set; }
        public string BusinessType { get; set; }
        public int NoOfLockers { get; set; }
        public string LockerSize { get; set; }
        public string SecurityMeasures { get; set; }
        public decimal HourlyRentalPrice { get; set; }
        public string StreetAddress { get; set; }
        public string Landmark { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string CurrentLocation { get; set; }

        public List<LockerImageDTO> LockerImages { get; set; } = new List<LockerImageDTO>();
    }

}
