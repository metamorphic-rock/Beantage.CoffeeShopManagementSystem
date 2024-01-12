using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;
using Beantage.CoffeeShopManagementSystem.Application.Mappers;
using Beantage.CoffeeShopManagementSystem.Contract.Dtos;
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
    public async Task<ProductTypeDto> CreateProductType(ProductTypeDto productType)
    {
        if(productType == null)
        {
            throw new Exception("Entity cannot be null");
        }
        if(productType.Id != 0)
        {
            throw new Exception("This type already existed");
        }
        var item = await _productTypeRepository.CreateProductType(productType.MapToDbo());
        return item.MapToDto();
    }

    public async Task DeleteProductType(int typeId)
    {
        var item = _productTypeRepository.DeleteProductType(typeId);
    }

    public async Task<IEnumerable<ProductTypeDto>> GetAllProductType()
    {
        var item = await _productTypeRepository.GetAllProductType();
        if (item == null)
        {
            throw new Exception("product type does not exist");
        }
        return item.MapToDtos();
    }

    public async Task<ProductType> GetProductTypeById(int id)
    {
        return await _productTypeRepository.GetProductTypeById(id);
    }

    public async Task<ProductType> UpdateProductType(int typeId, ProductType productType)
    {
        throw new NotImplementedException();
    }
}
