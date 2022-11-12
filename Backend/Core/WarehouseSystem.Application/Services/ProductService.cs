using WarehouseSystem.Application.Interfaces;
using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.Domain;

namespace WarehouseSystem.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product GetProductBySKU(int productSKU)
        {
            var product = _productRepository.GetProductBySKU(productSKU);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _productRepository.GetProducts();
            return products;
        }
    }
}
