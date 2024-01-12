using Beantage.CoffeeShopManagementSystem.Application.Interfaces.Services;
using Beantage.CoffeeShopManagementSystem.Contract.Dtos;
using Beantage.CoffeeShopManagementSystem.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Beantage.CoffeeShopManagementSystem.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly IProductTypeService _productTypeService;
    public ProductController(IProductService productService, IProductTypeService productTypeService)
    {
        _productService = productService;
        _productTypeService = productTypeService;
    }

    [HttpPost]
    [Route("createProductType")]
    public async Task<ActionResult<ProductTypeDto>> CreateProductType(ProductTypeDto request)
    {
        var productType = await _productTypeService.CreateProductType(request);
        if (productType == null)
        {
            return BadRequest();
        }
        return Ok(productType);
    }

    [HttpGet]
    [Route("getAllProductType")]
    public async Task<ActionResult<IEnumerable<ProductTypeDto>>> GetAllProductType()
    {
        var productTypes = await _productTypeService.GetAllProductType();
        return Ok(productTypes);
    }

    [HttpGet]
    [Route("getProductType{productTypeId:int}")]
    public async Task<ActionResult<ProductTypeDto>> GetProductTypeById(int productTypeId)
    {
        var productType = await _productTypeService.GetProductTypeById(productTypeId);
        if (productType == null)
        {
            return NotFound();
        }
        return Ok(productType);
    }

    [HttpPost]
    [Route("addProduct")]
    public async Task<ActionResult<ProductDto>> CreateProduct(ProductDto request)
    {
        var product = await _productService.CreateProduct(request);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpGet]
    [Route("getAllProducts")]
    public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
    {
        var products = await _productService.GetAllProducts();
        return Ok(products);
    }

    [HttpGet]
    [Route("getProduct/{productId:int}")]
    public async Task<ActionResult<ProductDto>> GetProductById(int productId)
    {
        var product = await _productService.GetProductById(productId);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }
}