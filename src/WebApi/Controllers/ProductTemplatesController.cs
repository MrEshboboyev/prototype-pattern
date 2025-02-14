using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("api/product-templates")]
public class ProductTemplatesController(ProductTemplateService productTemplateService) : ControllerBase
{
    [HttpPost("{id:int}/clone")]
    public IActionResult CloneProductTemplate(int id)
    {
        try
        {
            var clonedTemplate = productTemplateService.CloneProductTemplate(id);
            return Ok(clonedTemplate);
        }
        catch (ArgumentException ex)
        {
            return NotFound(ex.Message);
        }
    }
}
