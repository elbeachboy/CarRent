
using CarRent.CarManagement.Domain;
using CarRent.CustomerManagement.Domain;
using CarRent.ReservationManagement.Domain;
using Microsoft.EntityFrameworkCore; 

namespace CarRent.CustomerManagement.DbContext
{
    public class CarRentDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CarRentDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ZipCodePlace> ZipCodePlaces { get; set; }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarClass> CarClasses { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Customer>().ToTable("customer");
            modelBuilder.Entity<ZipCodePlace>().ToTable("plz");

            modelBuilder.Entity<Customer>().HasKey(c => c.Id).HasName("Pk_CustomerId");  
            modelBuilder.Entity<ZipCodePlace>().HasKey(zcp => zcp.Id).HasName("PK_ZipCodePlaceId");

            modelBuilder.Entity<ZipCodePlace>().Property(zcp => zcp.Id).HasColumnType("int").IsRequired(); 
            modelBuilder.Entity<ZipCodePlace>().Property(zcp => zcp.ZipCode).HasColumnType("int").IsRequired(); 
            modelBuilder.Entity<ZipCodePlace>().Property(zcp => zcp.Place).HasColumnType("nvarchar(100)").IsRequired();

            modelBuilder.Entity<Customer>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>().Property(c => c.Street).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.Surname).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.Name).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.ZipCodePlaceId).HasColumnType("int").IsRequired();;

            modelBuilder.Entity<Car>().ToTable("car");
            modelBuilder.Entity<CarClass>().ToTable("carclass");

            modelBuilder.Entity<Car>().HasKey(c => c.Id).HasName("Pk_CarId");  
            modelBuilder.Entity<CarClass>().HasKey(cc => cc.Id).HasName("PK_CarClassId");

            modelBuilder.Entity<CarClass>().Property(cc => cc.Id).HasColumnType("int").IsRequired(); 
            modelBuilder.Entity<CarClass>().Property(cc => cc.ClassType).HasColumnType("nvarchar(100)").IsRequired(); 
            modelBuilder.Entity<CarClass>().Property(cc => cc.PricePerDay).HasColumnType("int").IsRequired();

            modelBuilder.Entity<Car>().Property(c => c.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Car>().Property(c => c.Brand).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Car>().Property(c => c.Type).HasColumnType("nvarchar(100)").IsRequired();
            modelBuilder.Entity<Car>().Property(c => c.CarCLassId).HasColumnType("int").IsRequired();

            modelBuilder.Entity<Reservation>().ToTable("reservation");

            modelBuilder.Entity<Reservation>().HasKey(r => r.Id).HasName("Pk_ReservationId");  

            modelBuilder.Entity<Reservation>().Property(r => r.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Reservation>().Property(r => r.StartDateTime).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Reservation>().Property(r => r.EndDateTime).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Reservation>().Property(r => r.TotalDays).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Reservation>().Property(r => r.IsContract).HasColumnType("bit").HasDefaultValue(false);
            modelBuilder.Entity<Reservation>().Property(r => r.CustomerId).HasColumnType("char(36)").IsRequired();
            modelBuilder.Entity<Reservation>().Property(r => r.CarId).HasColumnType("char(36)").IsRequired();
        }
    }
}
