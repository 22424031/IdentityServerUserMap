using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using UserLoginBE.Entities.Configurations;
using UserLoginBE.Entities.Models;
using UserLoginBE.Seeds;

namespace UserLoginBE.Context
{
    public class UserLoginContext : IdentityDbContext<User>
    {
        public UserLoginContext(DbContextOptions options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new WardConfiguration());
            modelBuilder.ApplyConfiguration(new DistrictConfiguration());
            
        }
        public DbSet<District> District { get; set; }
        public DbSet<Ward> Ward { get; set; }
    }
}
