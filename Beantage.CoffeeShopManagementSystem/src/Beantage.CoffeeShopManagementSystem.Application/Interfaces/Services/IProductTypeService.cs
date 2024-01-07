using Beantage.CoffeeShopManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;

public interface IProductTypeService
{
    public Task<ProductType> CreateProductType(ProductType productType);
    public Task<ProductType> UpdateProductType(int typeId, ProductType productType);
    public Task DeleteProductType(int typeId);
    public Task<IEnumerable<ProductType>> GetAllProductType();
    public Task<ProductType> GetProductTypeById(int id);
}
