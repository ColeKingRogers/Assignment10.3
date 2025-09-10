using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment10._3.Models;

namespace Assignment10._3.Data
{   //represents the session with the database
    public class CarsContext : DbContext
    {
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=DESKTOP-0V74CCT;initial catalog=PCAD18Cars;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer { ManufacturerId = 1, ManufacturerName = "Toyota" },
                new Manufacturer { ManufacturerId = 2, ManufacturerName = "Honda" },
                new Manufacturer { ManufacturerId = 3, ManufacturerName = "Ford" },
                new Manufacturer { ManufacturerId = 4, ManufacturerName = "Chevrolet" },
                new Manufacturer { ManufacturerId = 5, ManufacturerName = "Nissan" }
            );  
            modelBuilder.Entity<Cars>().HasData(
                new Cars { Price = 18000, Vin = "1HGCM826", Model = "Civic", ManufacturerId = 2,  Year = 2016},
                new Cars { Price = 22000, Vin = "1FTFW1EF", Model = "F-150", ManufacturerId = 3, Year = 2018 },
                new Cars { Price = 25000, Vin = "1G1BE5SM", Model = "Cruze", ManufacturerId = 4, Year = 2019 },
                new Cars { Price = 27000, Vin = "1N4AL3AP", Model = "Altima", ManufacturerId = 5, Year = 2020 }
                );
        }
    }
}
