using WarehouseSystem.Domain;

namespace WarehouseSystem.Application.DTO
{
    public class ProductExemplarDTO
    {
        public int Code { get; set; }

        public int ProductSKU { get; set; }

        public int RowNumber { get; set; }

        public int CellNumber { get; set; }
    }
}
