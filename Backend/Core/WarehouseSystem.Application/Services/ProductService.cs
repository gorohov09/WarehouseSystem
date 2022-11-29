using System.Text;
using WarehouseSystem.Application.BO;
using WarehouseSystem.Application.Interfaces;
using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.DAL.Models;

namespace WarehouseSystem.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductDetailsBO GetProductBySKU(int productSKU)
        {
            var product = _productRepository.GetProductBySKU(productSKU);

            var productBO = new ProductDetailsBO()
            {
                ProductSKU = product.ProductSKU,
                CityProd = product.CityProd,
                DateProd = product.DateProd,
                Name = product.Name,
                IsCertificatePresent = product.IsCertificatePresent,
                PriceProd = product.PriceProd,
                Count = product.Exemplars.Count(),
                Exemplars = product.Exemplars.Select(ex => new ProductExemplarBO
                {
                    ProductSKU = ex.ProductSKU,
                    Code = ex.Code,
                    CellNumber = ex.CellNumber,
                    RowNumber = ex.RowNumber,
                }),
                Suppliers = GetSuppliersToString(product.Suppliers)
            };
            return productBO;
        }

        public IEnumerable<ProductBO> GetProducts()
        {
            var products = _productRepository.GetProducts();

            var productsBO = products.Select(product => new ProductBO
            {
                ProductSKU = product.ProductSKU,
                Name = product.Name,
                PriceProd = product.PriceProd,
                NumbOfCopies = product.Exemplars.Count(),
            }) ;

            return productsBO;
        }

        private string GetSuppliersToString(IEnumerable<Supplier> suppliers)
        {
            var result = new StringBuilder();

            foreach (var supplier in suppliers)
                result.Append($"{supplier.Name} ");

            return result.ToString();
        }
    }
}
