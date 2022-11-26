using System.Linq;
using WarehouseSystem.Application.DTO;
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

        public ProductDTO GetProductBySKU(int productSKU)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            var products = _productRepository.GetProducts();

            var productsDTO = products.Select(product => new ProductDTO
            {
                Name = product.Name,
                PriceProd = product.PriceProd,
                NumbOfCopies = product.Exemplars.Count(),
            }) ;
            return productsDTO;
        }
    }
}
