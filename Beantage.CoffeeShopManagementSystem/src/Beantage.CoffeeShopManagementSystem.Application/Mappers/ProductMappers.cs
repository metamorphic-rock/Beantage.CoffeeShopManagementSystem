using Beantage.CoffeeShopManagementSystem.Contract.Dtos;
using Beantage.CoffeeShopManagementSystem.Domain.Models;

namespace Beantage.CoffeeShopManagementSystem.Application.Mappers;

public static class ProductMappers
{
    public static Product MapToDbo(this ProductDto productDto)
    {
        return new Product
        {
           Name = productDto.Name,
           Description = productDto.Description,
           TypeId = productDto.TypeId,
           UnitPrice = productDto.UnitPrice,
           CreatedOn = productDto.CreatedOn,
           QuantityAvailable = productDto.QuantityAvailable,
           IsDiscontinued = productDto.IsDiscontinued,
        };
    }

    public static ProductDto MapToDto(this Product product)
    {
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            UnitPrice = product.UnitPrice,
            TypeId = product.TypeId,
            CreatedOn = product.CreatedOn,
            QuantityAvailable = product.QuantityAvailable,
            IsDiscontinued = product.IsDiscontinued,
        };
    }
    public static IEnumerable<ProductDto> MapToDtos(this IEnumerable<Product> products)
    {
        var productsDto = new List<ProductDto>();
        foreach (var product in products)
        {
            productsDto.Add(MapToDto(product));
        };
        return productsDto;
    }

    public static Product MapToExistingDbo (this Product product, ProductDto productDto)
    {
        product.Name = productDto.Name;
        product.Description = productDto.Description;
        product.UnitPrice = productDto.UnitPrice;
        product.CreatedOn = productDto.CreatedOn;
        product.QuantityAvailable = productDto.QuantityAvailable;
        product.IsDiscontinued = !productDto.IsDiscontinued;

        return product;
    }
}