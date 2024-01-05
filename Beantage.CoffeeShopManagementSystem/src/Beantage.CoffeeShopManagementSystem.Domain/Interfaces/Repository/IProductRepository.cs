using Beantage.CoffeeShopManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Domain.Interfaces.Repository;

public interface IProductRepository
{
    public Task<Product> CreateProduct(Product product);
    public Task UpdateProduct(int productId, Product product);
    public Task<IEnumerable<Product>> GetAllProducts();
    public Task<Product> GetProductById(int productId);
    public Task DeleteProduct(int productId);
}