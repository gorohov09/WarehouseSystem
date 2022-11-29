using WarehouseSystem.DAL.Models;

namespace WarehouseSystem.DAL.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductBySKU(int productSKU);

        Supplier GetSupplierById(int id);

        bool Save<T>(T product);
    }
}
