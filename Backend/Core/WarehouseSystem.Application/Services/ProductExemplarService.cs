using System.Linq;
using WarehouseSystem.Application.DTO;
using WarehouseSystem.Application.Interfaces;
using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.Domain;

namespace WarehouseSystem.Application.Services
{
    public class ProductExemplarService : IProductExemplarService
    {
        private readonly IProductExemplarRepository _productExemplarRepository;

        public ProductExemplarService(IProductExemplarRepository productExemplarRepository)
        {
            _productExemplarRepository = productExemplarRepository;
        }
    
        public IEnumerable<ProductExemplarDTO> GetProductExemplars()
        {
            var productsExemplar = _productExemplarRepository.GetProductExemplars();
            var productsExemplarDTO = productsExemplar.Select(productExemplar => new ProductExemplarDTO
            {
                Code = productExemplar.Code,
                ProductSKU = productExemplar.ProductSKU,
                RowNumber = productExemplar.RowNumber,
                CellNumber = productExemplar.CellNumber
            }) ;
            return productsExemplarDTO;
        }
    }
}
