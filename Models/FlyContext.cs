using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3.Models
{
    class FlyContext : DbContext
    {
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<CabinType> CabinTypes { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public event EventHandler OnSave;
        public override int SaveChanges()
        {
            OnSave(this, null);
            return base.SaveChanges();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Session3.mdf;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder b)
        {
            b.Entity<Route>()
                .HasOne(u => u.ArrivalAirport)
                .WithMany(u => u.ArrivalRoutes)
                .HasForeignKey(u => u.ArrivalAirportID);
            b.Entity<Route>()
                .HasOne(u => u.DepartureAirport)
                .WithMany(u => u.DepatureRoutes)
                .HasForeignKey(u => u.DepartureAirportID);
            b.Entity<Route>().Property(u => u.ArrivalAirportID).HasColumnName("ArrivalAirportID");
            b.Entity<Route>().Property(u => u.DepartureAirportID).HasColumnName("DepartureAirportID");
            b.Entity<Route>().Property(u => u.FlightTime).HasColumnName("FlightTime");
            b.Entity<Route>().Property(u => u.ID).HasColumnName("ID");
            b.Entity<Route>().Property(u => u.Distance).HasColumnName("Distance");

        }
    }
}
