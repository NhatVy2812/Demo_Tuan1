using Demo.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("products")]
    public class ProductViewController : Controller 
    {
        private readonly IProductService _productService;

        public ProductViewController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetHtmlView()
        {
            var products = await _productService.GetAllProductAsync();
            return View("Index", products);
        }
    }
}
