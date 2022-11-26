using WarehouseSystem.Domain;

namespace WarehouseSystem.Application.DTO
{
    public class ProductDTO
    {
        public string Name { get; set; }

        public decimal PriceProd { get; set; }

        public int NumbOfCopies { get; set; }
    }
}
