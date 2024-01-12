﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Repository;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using Beantage.CoffeeShopManagementSystem.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

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
            TypeId = product.Type.Id,
            QuantityAvailable = product.QuantityAvailable,
            CreatedOn = product.CreatedOn,
        };

        await _appDbContext.Products.AddAsync(item);
        await _appDbContext.SaveChangesAsync();
        return item;
    }

    public async Task DeleteProduct(int productId)
    {
        var item = await _appDbContext.Products.FirstOrDefaultAsync(x => x.Id == productId);
        if (item == null)
        {
            throw new Exception("Cannot find the product");
        }
        _appDbContext.Products.Remove(item);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        var items = _appDbContext.Products.ToList();
        return items;
    }

    public async Task<Product> GetProductById(int productId)
    {
       var item = await _appDbContext.Products.FirstOrDefaultAsync(x=> x.Id == productId);
       return item;
    }

    public async Task UpdateProduct(int productId, Product product)
    {
        var item = _appDbContext.Products.Update(product);
        await _appDbContext.SaveChangesAsync();
    }
}
