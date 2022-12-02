using Microsoft.EntityFrameworkCore;
using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.DAL.Models;

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
            var products = _context.Products
                .Include(products => products.Exemplars)
                .ToList();

            return products;
        }

        public Product GetProductBySKU(int productSKU)
        {
            var product = _context.Products
                .Include(product => product.Suppliers)
                .Include(product => product.Exemplars)
                .FirstOrDefault(prod => prod.ProductSKU == productSKU);

            return product;
        }

        public Supplier GetSupplierById(int id)
        {
            return _context.Suppliers.FirstOrDefault(x => x.Id == id);
        }

        public bool Save<T>(T product)
        {
            if (product == null)
                return false;

            _context.Add(product);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool Delete<T>(T product)
        {
            if (product == null)
                return false;

            _context.Remove(product);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool IsTakenSpace(int cellNumber, int rowNumber)
        {
            return _context.ProductExemplars.Any(ex => ex.CellNumber == cellNumber && ex.RowNumber == rowNumber);
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }
    }
}
