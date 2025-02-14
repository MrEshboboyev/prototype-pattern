using Microsoft.AspNetCore.Mvc;
using Application.Services;
using Domain.Models;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ProductService _productService;

    public ProductController() => _productService = new ProductService();

    [HttpPost("clone")]
    public IActionResult CloneProduct(
        [FromBody] Product originalProduct,
        decimal newPrice,
        int newStock)
    {
        var clonedProduct = _productService.DuplicateProduct(originalProduct, newPrice, newStock);
        return Ok(clonedProduct);
    }
}
