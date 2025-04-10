using Microsoft.AspNetCore.Mvc;
using ProductManagement.BusinessLayer.Abstract;
using ProductManagement.EntityLayer.Concrete;

namespace ProductManagement.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IProductService productService) : ControllerBase
{

    [HttpGet]
    public IActionResult GetAll()
    {
        var productList = productService.GetAll();
        if (productList is not null)
        {
            return Ok(productList);
        }

        return BadRequest();
    }
    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        var product = productService.GetById(id);
        if (product is not null)
        {
            return Ok(product);
        }
        return BadRequest();
    }

    [HttpPost]
    public IActionResult Add(Product product)
    {
        productService.Add(product);
        return Ok("Ürün Eklendi");
    }

    [HttpPut]
    public IActionResult Update(Product product)
    {
        productService.Update(product);
        return Ok("Ürün Güncellendi");
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        productService.Delete(id);
        return Ok("Ürün Silindi");

    }
}