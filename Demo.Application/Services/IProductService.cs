using Demo.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductAsync();
        Task<Product> GetByIdProductAsync(int id);
        Task<Product> CreateProductAsync(Product product);
        Task<int> UpdateProductAsync(int id, Product product);
        Task<int> DeleteProductAsync(int id);
    }
}
