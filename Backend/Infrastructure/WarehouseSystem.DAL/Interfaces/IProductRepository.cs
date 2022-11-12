using WarehouseSystem.Domain;

namespace WarehouseSystem.DAL.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
