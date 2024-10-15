using Demo.Application.Services;
using Demo.Domain.Enitities;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Authorization;
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
<<<<<<< HEAD
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAllAsync();
=======
        [Authorize]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _productService.GetAllProductAsync();
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
            return Ok(products);
        }

        [HttpGet("{id}")]
<<<<<<< HEAD
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
=======
        [Authorize]
        public async Task<IActionResult> GetByIdProduct(int id)
        {
            var product = await _productService.GetByIdProductAsync(id);
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
<<<<<<< HEAD
        public async Task<IActionResult> Create(Product product)
        {
            var createdProduct = await _productService.CreateAsync(product);
            return CreatedAtAction(nameof(GetById), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Product updatedProduct)
        {
            int existingProduct = await _productService.UpdateAsync(id, updatedProduct);
=======
        [Authorize]
        public async Task<IActionResult> CreateProduct(Product product)
        {
            var createdProduct = await _productService.CreateProductAsync(product);
            return CreatedAtAction(nameof(GetByIdProduct), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> UpdateProduct(int id, Product updatedProduct)
        {
            int existingProduct = await _productService.UpdateProductAsync(id, updatedProduct);
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
            if (existingProduct == 0)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
<<<<<<< HEAD
        public async Task<IActionResult> Delete(int id)
        {
            int product = await _productService.DeleteAsync(id);
=======
        [Authorize]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            int product = await _productService.DeleteProductAsync(id);
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
            if (product == 0)
            {
                return BadRequest();
            }
            return NoContent();
        }

    }
}
