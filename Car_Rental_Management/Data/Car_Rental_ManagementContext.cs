using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Car_Rental_Management.Domain;
using Car_Rental_Management.Configurations.Entities;

namespace Car_Rental_Management.Data
{
    public class Car_Rental_ManagementContext : DbContext
    {
        public Car_Rental_ManagementContext (DbContextOptions<Car_Rental_ManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Car_Rental_Management.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<Car_Rental_Management.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<Car_Rental_Management.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<Car_Rental_Management.Domain.Make> Make { get; set; } = default!;
        public DbSet<Car_Rental_Management.Domain.Model> Model { get; set; } = default!;
        public DbSet<Car_Rental_Management.Domain.Vehicle> Vehicle { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
