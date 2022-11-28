using WarehouseSystem.DAL.Models;

namespace WarehouseSystem.DAL.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductBySKU(int productSKU);
    }
}
