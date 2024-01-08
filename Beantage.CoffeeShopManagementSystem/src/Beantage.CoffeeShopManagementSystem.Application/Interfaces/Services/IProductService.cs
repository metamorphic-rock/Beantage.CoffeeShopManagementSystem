using Beantage.CoffeeShopManagementSystem.Domain.Models;
using Beantage.CoffeeShopManagementSystem.Contract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;

public interface IProductService
{
    public Task<ProductDto> CreateProduct(ProductDto product);
    public Task<ProductDto> UpdateProduct(int productId, ProductDto product);
    public Task<ProductDto> GetProductById(int productId);
    public Task<IEnumerable<ProductDto>> GetAllProducts();

}
