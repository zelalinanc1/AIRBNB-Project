using EntityLayer.Concrete;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\Local;database=AirbnbDB;integrated security=true;");

        }

        public DbSet<House> Houses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Property> Properties { get; set; }

    }
}
