using WarehouseSystem.Application.BO;

namespace WarehouseSystem.Application.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductBO> GetProducts();

        ProductDetailsBO GetProductBySKU(int productSKU);

        bool AddProduct(string name, string city, string dateProud, int count, decimal price, int numberSupplier, bool isCertificat);

        bool IssueProduct(int productSKU, int count);

        bool AddSupplier(string nameSupplier, string addressSupplier, string phoneSupplier);

        IEnumerable<SupplierBO> GetSuppliers();
    }
}
