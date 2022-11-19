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

        public Product GetProductBySKU(int productSKU)
        {
            var product = _productRepository.GetProductBySKU(productSKU);
            return product;
        }

        public IEnumerable<ProductDTO> GetProducts()
        {
            var products = _productRepository.GetProducts();
            var productsDTO = products.Select(product => new ProductDTO
            {
                ProductSKU = product.ProductSKU,
                Name = product.Name,
                CityProd = product.CityProd,
                DateProd = product.DateProd,
                NumbOfCopies = product.NumbOfCopies,
                PriceProd = product.PriceProd,
                VendorNumber = product.VendorNumber,
                IsCertificatePresent = product.IsCertificatePresent,
                Exemplars = product.Exemplars.ToList()
            }) ;
            return productsDTO;
        }
    }
}
