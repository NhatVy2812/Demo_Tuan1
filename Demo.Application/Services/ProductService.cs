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
<<<<<<< HEAD
        public async Task<Product> CreateAsync(Product product)
        {
            return await _productRepository.CreateAsync(product);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _productRepository.DeleteAsync(id);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task<int> UpdateAsync(int id, Product product)
        {
            return await _productRepository.UpdateAsync(id, product);
=======
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
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
        }
    }
}
