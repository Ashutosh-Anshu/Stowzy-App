using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_gateway.Domain.Entities.Account;

namespace user_gateway.DAL.Infrastructure.Persistence.Configurations
{
    public static class AccountEntityConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
        {
            // Configure RoomOwner Entity
            modelBuilder.Entity<RoomOwner>(builder =>
            {
                builder.HasKey(ro => ro.RoomOwnerId);

                builder.HasMany(ro => ro.Rooms)
                       .WithOne(r => r.RoomOwner)
                       .HasForeignKey(r => r.RoomOwnerId)
                       .OnDelete(DeleteBehavior.Cascade);

                builder.HasOne(ro => ro.RoomOwnerLogin)
                       .WithOne(rl => rl.RoomOwner)
                       .HasForeignKey<RoomOwnerLogin>(rl => rl.RoomOwnerId)
                       .OnDelete(DeleteBehavior.Cascade);

                builder.HasMany(ro => ro.StowzyDocuments)
                       .WithOne(sd => sd.RoomOwner)
                       .HasForeignKey(sd => sd.RoomOwnerId)
                       .OnDelete(DeleteBehavior.Cascade);
            });

            // Configure Room Entity
            modelBuilder.Entity<Room>(builder =>
            {
                builder.HasKey(r => r.RoomId);
                builder.Property(r => r.RoomId).ValueGeneratedOnAdd();
            });

            // Configure RoomOwnerLogin Entity
            modelBuilder.Entity<RoomOwnerLogin>(builder =>
            {
                builder.HasKey(rl => rl.LoginId);
                builder.Property(rl => rl.CreatedDate)
                       .HasDefaultValueSql("GETUTCDATE()");
            });

            // Configure StowzyDocument Entity
            modelBuilder.Entity<StowzyDocument>(builder =>
            {
                builder.HasKey(sd => sd.DocumentId);
                builder.Property(sd => sd.DocumentId).ValueGeneratedOnAdd();
            });
        }
    }
}
