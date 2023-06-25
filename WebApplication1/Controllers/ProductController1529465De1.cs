using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Dto.Values;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController1529465De1 : ControllerBase
    {
        private readonly IProductService1529465De1 _productService;

        public ProductController1529465De1(IProductService1529465De1 productService)
        {
			_productService = productService;
        }

        [HttpPost("create")]
        public IActionResult CreateProduct(CreateProductDto1529465De1 input)
        {
			try
			{
				_productService.CreateProduct(input);
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
    }
}
