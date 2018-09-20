using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EventsUs.Models;

namespace EventsUs.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EventsUs.Models.Event> Event { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
