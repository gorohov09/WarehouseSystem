using WarehouseSystem.Domain;

namespace WarehouseSystem.DAL.Interfaces
{
    public interface IProductExemplarRepository
    {
        IEnumerable<ProductExemplar> GetProductExemplars();
    }
}
