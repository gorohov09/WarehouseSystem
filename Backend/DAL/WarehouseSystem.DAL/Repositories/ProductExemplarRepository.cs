using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.DAL.Models;

namespace WarehouseSystem.DAL.Repositories
{
    public class ProductExemplarRepository : IProductExemplarRepository
    {
        private readonly WarehouseContext _context;

        public ProductExemplarRepository(WarehouseContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductExemplar> GetProductExemplars()
        {
            var productExemplars = _context.ProductExemplars.ToList();
            return productExemplars;
        }
    }
}
