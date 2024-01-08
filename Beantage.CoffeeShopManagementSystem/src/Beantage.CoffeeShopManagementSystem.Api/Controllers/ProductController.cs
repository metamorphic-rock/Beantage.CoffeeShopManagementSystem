using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;
using Beantage.CoffeeShopManagementSystem.Contract.Dtos;
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
    [Route("addProduct")]
    public async Task<ActionResult<ProductDto>> CreateProduct(ProductDto product)
    {
        var item = await _productService.CreateProduct(product);
        if (item == null)
        {
            return NotFound();
        }
        return Ok(item);
    }

    [HttpGet]
    [Route("getAllProducts")]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
    {
        var items = await _productService.GetAllProducts();
        return Ok(items);
    }

    [HttpGet]
    [Route("getProduct/{productId:int}")]
    public async Task<ActionResult<ProductDto>> GetProductById(int productId)
    {
        var item = await _productService.GetProductById(productId);
        if (item == null)
        {
            return NotFound();
        }
        return Ok(item);
    }
}