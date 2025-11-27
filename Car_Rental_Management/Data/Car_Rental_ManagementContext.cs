using Car_Rental_Management.Configurations.Entities;
using Car_Rental_Management.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental_Management.Data
{
    public class Car_Rental_ManagementContext(DbContextOptions<Car_Rental_ManagementContext> options) : IdentityDbContext<Car_Rental_ManagementUser>(options)
    {
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
