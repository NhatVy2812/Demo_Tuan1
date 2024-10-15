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
<<<<<<< HEAD
            var products = await _productService.GetAllAsync();
=======
            var products = await _productService.GetAllProductAsync();
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
            return View("Index", products);
        }
    }
}
