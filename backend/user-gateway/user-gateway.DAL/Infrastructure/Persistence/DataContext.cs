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
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Locker> Lockers { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<OwnerLogin> OwnerLogins { get; set; }
        public DbSet<OwnerDocument> OwnerDocuments { get; set; }
        public DbSet<LockerImage> LockerImages { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuRole> MenuRoles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

    }
}
