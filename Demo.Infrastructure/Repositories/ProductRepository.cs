using Demo.Domain.Enitities;
using Demo.Domain.Interface;
using Demo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseContext _dbContext;
        public ProductRepository(DatabaseContext databaseContext) 
        {
          _dbContext = databaseContext;
        }
        public async Task<List<Product>> GetAllProductAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product> GetByIdProductAsync(int id)
        {
            return await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            product.CreatedAt = DateTime.UtcNow;
            product.UpdatedAt = DateTime.UtcNow;
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<int> UpdateProductAsync(int id, Product product)
        {
            return await _dbContext.Products
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Name, product.Name)
                    .SetProperty(m => m.Code, product.Code)
                    .SetProperty(m => m.Description, product.Description)
                    .SetProperty(m => m.Category, product.Category)
                    .SetProperty(m => m.Brand, product.Brand)
                    .SetProperty(m => m.Type, product.Type)
                    .SetProperty(m => m.UpdatedAt, DateTime.UtcNow)
            );
                
        }

        public async Task<int> DeleteProductAsync(int id)
        {
            return await _dbContext.Products.Where(model => model.Id == id).ExecuteDeleteAsync();
        }
    }
}
