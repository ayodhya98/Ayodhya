using Microsoft.EntityFrameworkCore;
using vehicleBooking.Models;

namespace vehicleBooking.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Passenger> Passenger { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Chauffeur> Chauffeur { get; set;}
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Billing> Billing { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Cost> Cost { get; set; }
        public DbSet<VehicleAmenities> VehicleAmenities { get; set; }
        public DbSet<VehicleChauffeur> VehicleChauffeurs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<VehicleAmenities>()
                    .HasKey(pc => new { pc.VehicleId, pc.AmenityId });
            modelBuilder.Entity<VehicleAmenities>()
                    .HasOne(p => p.Vehicle)
                    .WithMany(pc => pc.VehicleAmenities)
                    .HasForeignKey(p => p.VehicleId)
                    .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<VehicleAmenities>()
                    .HasOne(p => p.Amenities)
                    .WithMany(pc => pc.VehicleAmenities)
                    .HasForeignKey(c => c.AmenityId)
                    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<VehicleChauffeur>()
                   .HasKey(pc => new { pc.VehicleId, pc.ChauffeurId });
            modelBuilder.Entity<VehicleChauffeur>()
                    .HasOne(p => p.Vehicle)
                    .WithMany(pc => pc.VehicleChauffeurs)
                    .HasForeignKey(p => p.VehicleId)
                    .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<VehicleChauffeur>()
                    .HasOne(p => p.Chauffeur)
                    .WithMany(pc => pc.VehicleChauffeurs)
                    .HasForeignKey(c => c.ChauffeurId)
                    .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Booking>()
                .HasOne(b => b.vehicle)
                .WithMany(b => b.bookings)
                .HasForeignKey(b => b.VehicleId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.passenger)
                .WithMany(b => b.bookings)
                .HasForeignKey(b => b.passengerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Booking>()
                .HasOne(b => b.chauffeurs)
                .WithMany(b => b.Bookings)
                .HasForeignKey(b => b.chauffeurId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Feedback>()
                .HasOne(b => b.passenger)
                .WithMany(b => b.feedbacks)
                .HasForeignKey(b => b.PassengerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Feedback>()
               .HasOne(b => b.chauffeur)
               .WithMany(b => b.feedbacks)
               .HasForeignKey(b => b.chauffeurId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Feedback>()
               .HasOne(b => b.vehicle)
               .WithMany(b => b.Feedbacks)
               .HasForeignKey(b => b.vehicleId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Billing>()
               .HasOne(b => b.Passenger)
               .WithMany(b => b.billings)
               .HasForeignKey(b => b.PassengerId)
               .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Chauffeur>()
              .HasOne(b => b.company)
              .WithMany(b => b.Chauffeurs)
              .HasForeignKey(b => b.companyId)
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Cost>().HasNoKey();

        }
    }
}
