using ProductManager.Application.Interfaces.Repositories;
using ProductManager.Application.Interfaces.Services;
using ProductManager.Domain.Entities;

namespace MyApp.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productRepository.GetById(id);
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _productRepository.GetAll();
        }

        public async Task AddProduct(Product product)
        {
            await _productRepository.Add(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _productRepository.Update(product);
        }

        public async Task DeleteProduct(int id)
        {
            await _productRepository.Delete(id);
        }
    }
}

