using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseSystem.Domain
{
    public class ProductExemplar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }

        public int ProductSKU { get; set; }

        [ForeignKey(nameof(ProductSKU))]
        public Product Product { get; set; }    

        public int RowNumber { get; set; }

        public int CellNumber { get; set; }
    }
}
