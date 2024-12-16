using BlueOcean.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueOcean.Data
{
    public class BlueOceanDbContext : DbContext
    {
        public BlueOceanDbContext(DbContextOptions<BlueOceanDbContext> options) : base(options) { }

        public DbSet<Boat> Boats { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Complain> Complains { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
       

            modelBuilder.Entity<Boat>()
                .HasOne(l => l.Location)
                .WithMany(b => b.Boats)
                .HasForeignKey(l => l.LocationId)
                .IsRequired();

            modelBuilder.Entity<Boat>()
                .HasOne(o => o.Owner)
                .WithMany(b => b.Boats)
                .HasForeignKey(o => o.OwnerId)
                .IsRequired();

            modelBuilder.Entity<Booking>()
               .HasOne(u => u.User)
               .WithMany(b => b.Bookings)
               .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<Booking>()
               .HasOne(a => a.Ad)
               .WithMany(b => b.Bookings)
               .HasForeignKey(a => a.AdId)
               .IsRequired();

            modelBuilder.Entity<Complain>()
               .HasOne(u => u.User)
               .WithMany(c => c.Complains)
               .HasForeignKey(u => u.UserId)
               .IsRequired();

            modelBuilder.Entity<Ticket>()
              .HasOne(u => u.User)
              .WithMany(t => t.Tickets)
              .HasForeignKey(u => u.UserId)
              .IsRequired();
        }

    }
}
