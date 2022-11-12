using WarehouseSystem.Domain;

namespace WarehouseSystem.Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();

        Product GetProductBySKU(int productSKU);
    }
}
