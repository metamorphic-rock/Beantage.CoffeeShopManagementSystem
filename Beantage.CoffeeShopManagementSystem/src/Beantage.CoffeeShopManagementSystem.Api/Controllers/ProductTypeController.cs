using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Beantage.CoffeeShopManagementSystem.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductTypeController : ControllerBase
{
    private readonly IProductTypeService _productTypeService;
    public ProductTypeController(IProductTypeService productTypeService)
    {
        _productTypeService = productTypeService;
    }
    [HttpPost]
    [Route("create")]
    public async Task<ActionResult<ProductType>> CreateProductType(ProductType request)
    {
        var productType = await _productTypeService.CreateProductType(request);
        if (productType == null)
        {
            return BadRequest();
        }
        return Ok(productType);
    }
    [HttpGet]
    [Route("getAll")]
    public async Task<ActionResult<IEnumerable<ProductType>>> GetAllProductType()
    {
        var request = _productTypeService.GetAllProductType();
        return Ok(request);
    }
}
