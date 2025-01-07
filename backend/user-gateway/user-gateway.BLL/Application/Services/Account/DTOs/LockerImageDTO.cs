namespace user_gateway.BLL.Application.Services.Account.DTOs
{
    public class LockerImageDTO
    {
        public Guid LockerImageId { get; set; }

        public string LockerImagePublicId { get; set; }

        public string LockerImageUrl { get; set; }

        public bool IsPrimary { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? ModifiedDate { get; set; } = null; 

    }

}
