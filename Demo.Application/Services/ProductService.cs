using Demo.Domain.Enitities;
using Demo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository blogRepository)
        {
            _productRepository = blogRepository;
        }
        public async Task<Product> CreateProductAsync(Product product)
        {
            return await _productRepository.CreateProductAsync(product);
        }

        public async Task<int> DeleteProductAsync(int id)
        {
            return await _productRepository.DeleteProductAsync(id);
        }

        public async Task<List<Product>> GetAllProductAsync()
        {
            return await _productRepository.GetAllProductAsync();
        }

        public async Task<Product> GetByIdProductAsync(int id)
        {
            return await _productRepository.GetByIdProductAsync(id);
        }

        public async Task<int> UpdateProductAsync(int id, Product product)
        {
            return await _productRepository.UpdateProductAsync(id, product);
        }
    }
}
