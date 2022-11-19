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
    
        public IEnumerable<ProductExemplar> GetProductExemplars()
        {
            var products = _productExemplarRepository.GetProductExemplars();
            return products;
        }
    }
}
