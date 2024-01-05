using Beantage.CoffeeShopManagementSystem.Application.Interfaces;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Beantage.CoffeeShopManagementSystem.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    [Route("createProduct")]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        var item = await _productService.CreateProduct(product);
        if (item == null)
        {
            return BadRequest();
        }
        return Ok(item);
    }
}