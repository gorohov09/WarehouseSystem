using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseSystem.Domain
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductSKU { get; set; }

        public string Name { get; set; }

        public string CityProd { get; set; }

        public DateTime DateProd { get; set; }

        public int NumbOfCopies { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal PriceProd { get; set; }

        public int VendorNumber { get; set; }

        public bool IsCertificatePresent { get; set; }

        public IEnumerable<ProductExemplar> Exemplars { get; set; } = new List<ProductExemplar>(); //свойство навигации 
    }
}
