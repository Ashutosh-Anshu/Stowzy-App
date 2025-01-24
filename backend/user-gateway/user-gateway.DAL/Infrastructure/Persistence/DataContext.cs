using Microsoft.EntityFrameworkCore;
using System;
using user_gateway.Domain.Entities.Account;
using user_gateway.Domain.Entities.Roles;


namespace user_gateway.DAL.Infrastructure.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SYS_ActionInRole>()
                .HasKey(ar => new { ar.RoleId, ar.ActionId }); // Composite Key

            modelBuilder.Entity<SYS_ActionInRole>()
                .HasOne(ar => ar.SYS_Role) // Role Relationship
                .WithMany(r => r.SYS_ActionInRole)
                .HasForeignKey(ar => ar.RoleId);

            modelBuilder.Entity<SYS_ActionInRole>()
                .HasOne(ar => ar.SYS_Action) // Action Relationship
                .WithMany()
                .HasForeignKey(ar => ar.ActionId);

        }


        public DbSet<Owner> Owners { get; set; }
        public DbSet<OwnerLogin> OwnerLogins { get; set; }
        public DbSet<OwnerDocument> OwnerDocuments { get; set; }
        public DbSet<Locker> Lockers { get; set; }
        public DbSet<LockerImage> LockerImages { get; set; }


        public DbSet<SYS_Menu> SYS_Menus { get; set; }
        public DbSet<SYS_Action> SYS_Actions { get; set; }
        public DbSet<SYS_Role> SYS_Roles { get; set; }
        public DbSet<SYS_ActionInRole> SYS_ActionInRoles { get; set; }
        public DbSet<SYS_UserInRole> SYS_UserInRoles { get; set; }



    }
}
