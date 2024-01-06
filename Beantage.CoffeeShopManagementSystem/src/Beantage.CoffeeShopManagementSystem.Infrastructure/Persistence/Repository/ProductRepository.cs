using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Data;

namespace Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Repository;

public class ProductRepository : IProductRepository
{
    private readonly BeantageDbContext _appDbContext;
    public ProductRepository(BeantageDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<Product> CreateProduct(Product product)
    {
        var item = new Product
        {
            Name = product.Name,
            UnitPrice = product.UnitPrice,
            Description = product.Description,
            //Category = product.Category,
            CreatedOn = product.CreatedOn,
        };

        await _appDbContext.Products.AddAsync(item);
        var isSuccess = await _appDbContext.SaveChangesAsync();
        return item;
    }

    public async Task DeleteProduct(int productId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public async Task<Product> GetProductById(int productId)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateProduct(int productId, Product product)
    {
        throw new NotImplementedException();
    }
}
