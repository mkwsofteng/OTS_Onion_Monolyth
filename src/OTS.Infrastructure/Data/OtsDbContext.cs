using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OTS.Domain.Entities;

namespace OTS.Infrastructure.Data
{
    //public class OtsDbContext : DbContext
    //{
    //    public OtsDbContext(DbContextOptions<OtsDbContext> options)
    //        : base(options)
    //    {
    //    }

    //    public DbSet<ApplicationUser> Users { get; set; }
    //    public DbSet<Event> Events { get; set; }
    //    public DbSet<Seat> Seats { get; set; }
    //    public DbSet<Booking> Bookings { get; set; }
    //    public DbSet<Payment> Payments { get; set; }
    //}


    public class OtsDbContext : IdentityDbContext
    {
        public OtsDbContext(DbContextOptions<OtsDbContext> options)
            : base(options)
        { }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; } 
    
    }
}
