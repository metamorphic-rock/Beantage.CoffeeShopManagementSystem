using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Repository;

public class ProductTypeRepository : IProductTypeRepository
{
    private readonly BeantageDbContext _appDbContext;
    public ProductTypeRepository(BeantageDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    public async Task<ProductType> CreateProductType(ProductType productType)
    {
        var item = new ProductType
        {
            Name = productType.Name,
            Description = productType.Description,
            IsBeverage = productType.IsBeverage,
        };
        await _appDbContext.ProductTypes.AddAsync(item);
        await _appDbContext.SaveChangesAsync();
        return item;
    }

    public async Task DeleteProductType(int typeId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<ProductType>> GetAllProductType()
    {
        var items = _appDbContext.ProductTypes.ToList();
        return items;
    }

    public async Task<ProductType> GetProductTypeById(int id)
    {
        var item = await _appDbContext.ProductTypes.FindAsync(id);
        return item;
    }

    public async Task<ProductType> UpdateProductType(int typeId, ProductType productType)
    {
        throw new NotImplementedException();
    }
}
