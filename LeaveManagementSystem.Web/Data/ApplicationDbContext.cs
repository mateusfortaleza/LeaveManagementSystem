using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole 
                { 
                    Id = "3ab33054-b56c-46c8-bebc-1776fbd72957",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                }, 
                new IdentityRole 
                {
                    Id = "6253acfb-87fe-41e2-b652-1253cfc89bc2",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole 
                {
                    Id = "3737dfa2-25d4-4208-a282-1d36bcedb791",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );

            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "b1c2d3e4-f5a6-7b8c-9d0e-f1a2b3c4d5e6",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                PasswordHash = "AQAAAAIAAYagAAAAEAi0MtD61WkEvg23ppdEEA67aAdJf4JbziuTytj1I0ISzqg3I2r0rUYyc6wITmwJIg==",
                EmailConfirmed = true,
                ConcurrencyStamp = "stamp-admin-user", // Adding a static value
                SecurityStamp = "SECURITYSTAMP", // Adding a static value
                FirstName = "Default",
                LastName = "Admin",
                DateOfBirth = new DateOnly(1985, 12, 01)
            });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3737dfa2-25d4-4208-a282-1d36bcedb791",
                    UserId = "b1c2d3e4-f5a6-7b8c-9d0e-f1a2b3c4d5e6"
                }
                );

        }
        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}

