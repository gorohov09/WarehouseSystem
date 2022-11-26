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
            var product = _productRepository.GetProductBySKU(productSKU);
            var productDTO = new ProductDTO
            {
                ProductSKU = product.ProductSKU,
                Name = product.Name,
                CityProd = product.CityProd,
                DateProd = product.DateProd,
                PriceProd = product.PriceProd,
                IsCertificatePresent = product.IsCertificatePresent,
                ExemplarsDTO = product.Exemplars.Select(exemplar => new ProductExemplarDTO
                {
                    Code = exemplar.Code,
                    ProductSKU = exemplar.ProductSKU,
                    RowNumber = exemplar.RowNumber,
                    CellNumber = exemplar.CellNumber
                }).ToList()
            };
            return productDTO;
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
                PriceProd = product.PriceProd,
                IsCertificatePresent = product.IsCertificatePresent,
                ExemplarsDTO = product.Exemplars.Select(exemplar => new ProductExemplarDTO
                {
                    Code = exemplar.Code,
                    ProductSKU = exemplar.ProductSKU,
                    RowNumber = exemplar.RowNumber,
                    CellNumber = exemplar.CellNumber
                }).ToList()
            }) ;
            return productsDTO;
        }
    }
}
