using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EventsUs.Models;
using Microsoft.AspNetCore.Identity;

namespace EventsUs.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // creating users for test 
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           /* const int RATINGS_AMNT = 20;

            var pHasher = new PasswordHasher<User>();

            User adminUser = new User
            {
                Id = "admin_ID_123456789",
                Email = "admin@eventus.com",
                UserName = "admin",
                EmailConfirmed = true,
                SecurityStamp = "admin@eventus.com",
                NormalizedEmail = "admin@eventus.com",
                NormalizedUserName = "admin@eventus.com",
                LockoutEnabled = true,

            };
            adminUser.PasswordHash
                = pHasher.HashPassword(adminUser, "EventUs123.");
            builder.Entity<User>().HasData(adminUser);



            var users4_testRatings = new User[RATINGS_AMNT];
            for (var i = 0; i < RATINGS_AMNT; i++)
            {
                string userID = "Eu_" + (7000 + i);
                string email = userID + "@eventus.com";
                string username = "EventUs_" + userID;
                int iage = 20;

                //dont touch
                users4_testRatings[i] = new User
                {
                    Id = "" + userID,
                    Email = email + "",
                    UserName = username + "",
                    EmailConfirmed = true,
                    SecurityStamp = email + "",
                    NormalizedEmail = email + "",
                    NormalizedUserName = email + "",
                    LockoutEnabled = true,
                    age = iage,
                };

                users4_testRatings[i].PasswordHash
                    = pHasher.HashPassword(users4_testRatings[i], "Aa123456!" + userID);
            }

            builder.Entity<User>().HasData(users4_testRatings);


            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "user",
                    NormalizedName = "user",
                    ConcurrencyStamp = "user",
                    Id = "1"
                });
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin",
                    ConcurrencyStamp = "admin",
                    Id = "2"
                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "admin_ID_123456789"
                });
            for (var i = 0; i < RATINGS_AMNT; i++)
            {
                string userID = "Eu_" + (7000 + i);
                builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = userID + ""
                });
            }*/
        }

        public DbSet<EventsUs.Models.Event> Event { get; set; }
        public DbSet<EventsUs.Models.FindFriends> FindFriends { get; set; }
        public DbSet<EventsUs.Models.ApplicationUser> ApplicationUsers { get; set; }

    }
}
