using WarehouseSystem.Domain;

namespace WarehouseSystem.Application.DTO
{
    public class ProductDTO
    {
        public int ProductSKU { get; set; }

        public string Name { get; set; }

        public string CityProd { get; set; }

        public DateTime DateProd { get; set; }

        public int NumbOfCopies { get; set; }

        public decimal PriceProd { get; set; }

        public int VendorNumber { get; set; }

        public bool IsCertificatePresent { get; set; }

        public List<ProductExemplarDTO> ExemplarsDTO { get; set; } = new List<ProductExemplarDTO>(); //свойство навигации
    }
}
