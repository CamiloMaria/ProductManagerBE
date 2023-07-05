using Microsoft.AspNetCore.Mvc;
using ProductManager.Application.Interfaces;
using ProductManager.Domain.Entities;

namespace ProductManager.API.Controllers
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
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddProducto([FromBody] Product product)
        {
            await _productService.AddProduct(product);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProducto(int id, [FromBody] Product product)
        {
            var existingProduct = await _productService.GetProductById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.Image = product.Image;

            await _productService.UpdateProduct(existingProduct);
            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            await _productService.DeleteProduct(product);
            return Ok(product);
        }
    }
}
