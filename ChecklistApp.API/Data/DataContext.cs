using ChecklistApp.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChecklistApp.API.Data
{
    public class DataContext: IdentityDbContext<User, Role, int, IdentityUserClaim<int>, 
    UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext> options): base (options) {}
        public DbSet<Value> Values { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Asset> Assets { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<UserRole>(UserRole =>
        {
            UserRole.HasKey(ur => new{ur.UserId, ur.RoleId});

            UserRole.HasOne(ur => ur.Role)
            .WithMany( r => r.UserRoles)
            .HasForeignKey(ur => ur.RoleId)
            .IsRequired();

            UserRole.HasOne(ur => ur.User)
            .WithMany( r => r.UserRoles)
            .HasForeignKey(ur => ur.UserId)
            .IsRequired();

        });

    }
    }
    
}