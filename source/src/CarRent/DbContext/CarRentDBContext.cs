
using CarRent.CustomerManagement.Domain;
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

        }
    }
}
