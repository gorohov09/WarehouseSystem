using WarehouseSystem.Application.BO;

namespace WarehouseSystem.Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductBO> GetProducts();

        ProductBO GetProductBySKU(int productSKU);
    }
}
