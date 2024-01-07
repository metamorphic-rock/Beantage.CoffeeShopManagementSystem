using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Application.Services;

public class ProductTypeService : IProductTypeService
{
    private readonly IProductTypeRepository _productTypeRepository;
    public ProductTypeService(IProductTypeRepository productTypeRepository)
    {
        _productTypeRepository = productTypeRepository;
    }
    public async Task<ProductType> CreateProductType(ProductType productType)
    {
        if(productType == null)
        {
            throw new Exception("Entity cannot be null");
        }
        if(productType.Id != 0)
        {
            throw new Exception("This type already existed");
        }
        var item = await _productTypeRepository.CreateProductType(productType);
        return item;
    }

    public async Task DeleteProductType(int typeId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<ProductType>> GetAllProductType()
    {
        return await _productTypeRepository.GetAllProductType();
    }

    public async Task<ProductType> GetProductTypeById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<ProductType> UpdateProductType(int typeId, ProductType productType)
    {
        throw new NotImplementedException();
    }
}
