using Microsoft.EntityFrameworkCore;
using Beantage.CoffeeShopManagementSystem.Domain;
using Beantage.CoffeeShopManagementSystem.Domain.Models;

namespace Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<Employee> Employees { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}