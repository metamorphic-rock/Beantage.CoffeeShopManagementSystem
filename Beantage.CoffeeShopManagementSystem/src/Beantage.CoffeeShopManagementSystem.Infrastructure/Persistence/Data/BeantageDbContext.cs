using Microsoft.EntityFrameworkCore;
using Beantage.CoffeeShopManagementSystem.Domain;
using Beantage.CoffeeShopManagementSystem.Domain.Models;

namespace Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Data;

public class BeantageDbContext : DbContext, IBeantageDbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<Employee> Employees { get; set; }

    public BeantageDbContext(DbContextOptions<BeantageDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the UnitPrice property
        modelBuilder.Entity<Product>()
            .Property(p => p.UnitPrice)
            .HasColumnType("decimal(18,2)"); // Adjust precision and scale as needed

        // Other configurations...

        base.OnModelCreating(modelBuilder);
    }
}