using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace user_gateway.Domain.Entities.Account
{

    public class RegisterOwnerModel
    {
        public Locker Locker { get; set; }
        public Owner Owner { get; set; }
        public OwnerLogin OwnerLogin { get; set; }
        public OwnerDocument OwnerDocument { get; set; }
        public List<LockerImage> LockerImages { get; set; }

    }


}
