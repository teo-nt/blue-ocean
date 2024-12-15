using BlueOcean.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueOcean.Data
{
    public class BlueOceanDbContext : DbContext
    {
        public BlueOceanDbContext(DbContextOptions<BlueOceanDbContext> options) : base(options) { }

        public DbSet<Boat> Boats { get; set; }
        public DbSet<BoatCategory> BoatCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Complain> Complains { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Boat>()
                .HasOne(b => b.BoatCategory)
                .WithMany(bc => bc.Boats)
                .HasForeignKey(b => b.BoatCategoryId)
                .IsRequired();
        }

    }
}
