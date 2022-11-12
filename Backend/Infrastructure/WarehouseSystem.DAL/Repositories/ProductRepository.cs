using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.Domain;

namespace WarehouseSystem.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly WarehouseContext _context;

        public ProductRepository(WarehouseContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }
    }
}
