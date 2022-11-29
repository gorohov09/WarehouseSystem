namespace WarehouseSystem.Application.BO
{
    public class ProductDetailsBO
    {
        public int ProductSKU { get; set; }

        public string Name { get; set; }

        public string CityProd { get; set; }

        public DateTime DateProd { get; set; }

        public int Count { get; set; }

        public decimal PriceProd { get; set; }

        public bool IsCertificatePresent { get; set; }

        public IEnumerable<ProductExemplarBO> Exemplars { get; set; } = new List<ProductExemplarBO>(); //свойство навигации 

        public string Suppliers { get; set; }
    }
}
