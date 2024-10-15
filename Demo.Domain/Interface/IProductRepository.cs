using Demo.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Interface
{
    public interface IProductRepository
    {
<<<<<<< HEAD
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> CreateAsync (Product product);
        Task<int> UpdateAsync (int id, Product product);
        Task<int> DeleteAsync (int id);
=======
        Task<List<Product>> GetAllProductAsync();
        Task<Product> GetByIdProductAsync(int id);
        Task<Product> CreateProductAsync(Product product);
        Task<int> UpdateProductAsync(int id, Product product);
        Task<int> DeleteProductAsync(int id);
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
    }
}
