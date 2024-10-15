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
<<<<<<< HEAD
        public async Task<List<Product>> GetAllAsync()
=======
        public async Task<List<Product>> GetAllProductAsync()
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
        {
            return await _dbContext.Products.ToListAsync();
        }

<<<<<<< HEAD
        public async Task<Product> GetByIdAsync(int id)
=======
        public async Task<Product> GetByIdProductAsync(int id)
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
        {
            return await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

<<<<<<< HEAD
        public async Task<Product> CreateAsync(Product product)
=======
        public async Task<Product> CreateProductAsync(Product product)
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
        {
            product.CreatedAt = DateTime.UtcNow;
            product.UpdatedAt = DateTime.UtcNow;
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

<<<<<<< HEAD
        public async Task<int> UpdateAsync(int id, Product product)
=======
        public async Task<int> UpdateProductAsync(int id, Product product)
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
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

<<<<<<< HEAD
        public async Task<int> DeleteAsync(int id)
=======
        public async Task<int> DeleteProductAsync(int id)
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
        {
            return await _dbContext.Products.Where(model => model.Id == id).ExecuteDeleteAsync();
        }
    }
}
