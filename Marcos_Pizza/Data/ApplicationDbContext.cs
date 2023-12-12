
using Marcos_Pizza.Web.Configuration.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Marcos_Pizza.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserSeedConfiguration());
            
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserRoleConfiguration());    
        }
        public DbSet<User> User { get; set; }   
        public DbSet<Orders> Orders { get; set; }   
        public DbSet<Products> Products { get; set; }   
    }
}