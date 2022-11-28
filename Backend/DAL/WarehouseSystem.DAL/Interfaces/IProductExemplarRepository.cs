using WarehouseSystem.DAL.Models;

namespace WarehouseSystem.DAL.Interfaces
{
    public interface IProductExemplarRepository
    {
        IEnumerable<ProductExemplar> GetProductExemplars();
    }
}
