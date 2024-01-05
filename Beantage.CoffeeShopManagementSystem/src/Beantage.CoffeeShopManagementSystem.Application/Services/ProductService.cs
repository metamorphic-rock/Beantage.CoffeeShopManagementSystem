using Beantage.CoffeeShopManagementSystem.Application.Interfaces;
using Beantage.CoffeeShopManagementSystem.Domain.Interfaces.Repository;
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

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product> CreateProduct(Product product)
    {
       var item = await _productRepository.CreateProduct(product);
       return item;
    }
}
