using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseSystem.DAL.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public IEnumerable<Supply> Deliveries { get; set; } = new List<Supply>();
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
