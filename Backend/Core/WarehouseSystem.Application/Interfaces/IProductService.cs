using WarehouseSystem.Application.DTO;
using WarehouseSystem.Domain;

namespace WarehouseSystem.Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetProducts();

        Product GetProductBySKU(int productSKU);
    }
}
