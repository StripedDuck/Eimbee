using Microsoft.EntityFrameworkCore;
using Eimbee.DataAccessLayer.Extensions;
using Eimbee.DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Eimbee.Core.Enums;

namespace Eimbee.DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            this.ApplyGlobalSystemObjectFilter();
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Airline> Airlines {get;set; }
        public DbSet<AirlineRoute> AirlineRoutes { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<AircraftType> AircraftTypes { get; set; }
        public DbSet<Pilot> Pilots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
                .HasIndex(p => new { p.Iso3 });

            modelBuilder.Entity<Airport>()
                .HasIndex(p => new { p.IcaoCode });

            var rankConverter = new EnumToStringConverter<Rank>();

            modelBuilder
                .Entity<Pilot>()
                .Property(e => e.Rank)
                .HasConversion(rankConverter);

            var roleConverter = new EnumToStringConverter<Role>();

            modelBuilder
                .Entity<Pilot>()
                .Property(e => e.Role);

            var aircraftStatusConverter = new EnumToStringConverter<AircraftStatus>();

            modelBuilder
                .Entity<Aircraft>()
                .Property(e => e.Status)
                .HasConversion(aircraftStatusConverter);
        }
    }
}
