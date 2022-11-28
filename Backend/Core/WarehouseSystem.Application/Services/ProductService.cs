using WarehouseSystem.Application.BO;
using WarehouseSystem.Application.Interfaces;
using WarehouseSystem.DAL.Interfaces;

namespace WarehouseSystem.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductBO GetProductBySKU(int productSKU)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductBO> GetProducts()
        {
            var products = _productRepository.GetProducts();

            var productsDTO = products.Select(product => new ProductBO
            {
                Name = product.Name,
                PriceProd = product.PriceProd,
                NumbOfCopies = product.Exemplars.Count(),
            }) ;
            return productsDTO;
        }
    }
}
