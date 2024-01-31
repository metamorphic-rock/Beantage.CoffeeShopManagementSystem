using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;
using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beantage.CoffeeShopManagementSystem.Contract.Dtos;
using Beantage.CoffeeShopManagementSystem.Application.Mappers;

namespace Beantage.CoffeeShopManagementSystem.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IProductTypeRepository _productTypeRepository;

    public ProductService(IProductRepository productRepository,
        IProductTypeRepository productTypeRepository)
    {
        _productRepository = productRepository;
        _productTypeRepository = productTypeRepository;
    }

    public async Task<ProductDto> CreateProduct(ProductDto product)
    {
        var productItem = product.MapToDbo();
        if (productItem.TypeId == 0)
        {
            throw new Exception("Type id cannot be null or 0");
        }
        productItem.Type = await _productTypeRepository.GetProductTypeById(productItem.TypeId);
        if (productItem.Type == null)
        {
            throw new Exception("Type is does not exist");
        }

        var item = new Product
        {
            Name = product.Name,
            UnitPrice = product.UnitPrice,
            Description = product.Description,
            TypeId = product.Type.Id,
            QuantityAvailable = product.QuantityAvailable,
            CreatedOn = product.CreatedOn,
        };

        var itemDbo = await _productRepository.CreateProduct(item);
        return itemDbo.MapToDto();
    }

    public async Task<ProductDto> UpdateProduct(int productId, ProductDto product)
    {
        var item = await _productRepository.GetProductById(productId);
        var productDbo = item.MapToExistingDbo(product);
        if (item == null)
        {
            throw new Exception("product cannot be found");
        }
        item.Id = productDbo.Id;
        item.Type = await _productTypeRepository.GetProductTypeById(productId);
        item.TypeId = productDbo.TypeId;
        item.Description = productDbo.Description;
        item.CreatedOn = productDbo.CreatedOn;
        item.UnitPrice = productDbo.UnitPrice;
        item.IsDiscontinued = productDbo.IsDiscontinued;

        await _productRepository.UpdateProduct(productId, productDbo);
        return item.MapToDto();
    }

    public async Task<ProductDto> GetProductById(int productId)
    {
        var item = await _productRepository.GetProductById(productId);
        return item.MapToDto();
    }

    public async Task<IEnumerable<ProductDto>> GetAllProducts()
    {
        var items = await _productRepository.GetAllProducts();
        return items.MapToDtos();
    }

    public async Task<IEnumerable<ProductDto>> GetAllBeverage()
    {
        var items = await _productRepository.GetAllProducts();
        if (items.Count() == 0)
        {
            return Enumerable.Empty<ProductDto>();
        }
        var beverage = items.Where(x => x.Type.IsBeverage == true);
        return beverage.MapToDtos();
    }

    public async Task<IEnumerable<ProductDto>> GetAllNonBeverage()
    {
        var items = await _productRepository.GetAllProducts();
        if (items.Count() == 0)
        {
            return Enumerable.Empty<ProductDto>();
        }
        var nonBeverage = items.Where(x => x.Type.IsBeverage == false);
        return nonBeverage.MapToDtos();
    }
    public async Task<IEnumerable<ProductDto>> GetProductsByType(int typeId)
    {
        var items = await _productRepository.GetProductsByType(typeId);
        return items.MapToDtos();
    }

    public async Task<ProductDto> UpdateProductQuantity(int productId, int quantity)
    {
        var item = await _productRepository.GetProductById(productId);
        if (item == null)
        {
            throw new ArgumentException("cannot find product");
        }
        var availableQuantity = item.QuantityAvailable;
        availableQuantity += quantity;
        item.QuantityAvailable = availableQuantity;
        if (item.QuantityAvailable >= 0)
        {
            try
            {
                await _productRepository.UpdateProduct(productId, item);
                return item.MapToDto();
            }
            catch
            {
                throw new Exception("update not successful");
            }
        }
        return item.MapToDto();
    }
}
