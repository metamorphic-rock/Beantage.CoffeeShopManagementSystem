using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;
using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public async Task<Product> CreateProduct(Product product)
    {
       if (product.TypeId == 0)
       {
            throw new Exception("Type id cannot be null or 0");
       }
       product.Type = await _productTypeRepository.GetProductTypeById(product.TypeId);
       var item = await _productRepository.CreateProduct(product);
       return item;
    }
}
