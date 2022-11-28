using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseSystem.Domain
{
    public class Supply
    {
        [Required]
        public int SupplierId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("SupplierId")]
        public Supplier Supplier { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public DateTime DeliveryDate { get; set; }
    }
}
