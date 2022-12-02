using WarehouseSystem.DAL.Models;

namespace WarehouseSystem.DAL.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        IEnumerable<Product> GetProductsBySKU(int productSKU);

        IEnumerable<Product> GetProductsByName(string productName);

        Product GetProductBySKU(int productSKU);

        Supplier GetSupplierById(int id);

        bool Save<T>(T product);

        bool Delete<T>(T product);

        bool IsTakenSpace(int cellNumber, int rowNumber);

        IEnumerable<Supplier> GetAllSuppliers();
    }
}
