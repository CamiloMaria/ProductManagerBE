using ProductManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Application.Interfaces
{
    public interface IProductService
    {
        Task<Product> GetProductById(int id);
        Task<IEnumerable<Product>> GetAllProducts();
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(Product product);
    }
}
