using Beantage.CoffeeShopManagementSystem.Contract.Dtos;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beantage.CoffeeShopManagementSystem.Application.Mappers;
public static class ProductTypeMappers
{
    public static ProductType MapToDbo (this ProductTypeDto productTypeDto)
    {
        return new ProductType
        {
            Name = productTypeDto.Name,
            Description = productTypeDto.Description,
            IsBeverage = productTypeDto.IsBeverage,
        };
    }

    public static ProductTypeDto MapToDto (this ProductType productType)
    {
        return new ProductTypeDto
        {
            Id = productType.Id,
            Name = productType.Name,
            Description = productType.Description,
            IsBeverage = productType.IsBeverage
        };
    }

    public static IEnumerable<ProductTypeDto> MapToDtos (this IEnumerable<ProductType> productTypes)
    {
        var productTypesDto = new List<ProductTypeDto> ();
        foreach (var productType in productTypes)
        {
            productTypesDto.Add (MapToDto (productType));
        }
        return productTypesDto;
    }

    public static ProductType MapToExistingDbo (this ProductType productType, ProductTypeDto productTypeDto)
    {
        productType.Name = productTypeDto.Name;
        productType.Description = productTypeDto.Description;
        productType.IsBeverage = productTypeDto.IsBeverage;

        return productType;
    }
}
