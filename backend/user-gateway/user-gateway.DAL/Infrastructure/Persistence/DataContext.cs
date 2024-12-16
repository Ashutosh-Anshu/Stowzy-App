using Microsoft.EntityFrameworkCore;
using System;
using user_gateway.DAL.Infrastructure.Persistence.Configurations;
using user_gateway.Domain.Entities.Account;


namespace user_gateway.DAL.Infrastructure.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AccountEntityConfiguration.Configure(modelBuilder);
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomOwner> RoomOwners { get; set; }
        public DbSet<RoomOwnerLogin> RoomOwnerLogins { get; set; }
        public DbSet<StowzyDocument> StowzyDocuments { get; set; }
    }
}
