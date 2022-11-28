using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseSystem.DAL.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductSKU { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public string CityProd { get; set; }

        public DateTime DateProd { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal PriceProd { get; set; }

        public bool IsCertificatePresent { get; set; }

        public IEnumerable<ProductExemplar> Exemplars { get; set; } = new List<ProductExemplar>(); //свойство навигации 

        public IEnumerable<Supply> Deliveries { get; set; } = new List<Supply>();

        public IEnumerable<Supplier> Suppliers { get; set; } = new List<Supplier>();
    }
}
