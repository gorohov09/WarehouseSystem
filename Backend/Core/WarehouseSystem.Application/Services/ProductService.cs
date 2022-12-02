using System.Text;
using WarehouseSystem.Application.BO;
using WarehouseSystem.Application.Interfaces;
using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.DAL.Models;

namespace WarehouseSystem.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool AddProduct(string name, string city, string dateProud, int count, decimal price, int numberSupplier, bool isCertificat)
        {
            Random random = new Random();

            if (count <= 0 || price <= 0)
                return false;

            if (numberSupplier <= 0)
                return false;

            var timeList = GetTime(dateProud);

            var exemplarsEntity = new List<ProductExemplar>();

            for (int i = 0; i < count; i++)
            {
                var cellNumber = random.Next(1, 100);
                var rowNumber = random.Next(1, 100);

                var takenSpace = _productRepository.IsTakenSpace(cellNumber, rowNumber);

                if (!takenSpace) 
                {
                    var examplar = new ProductExemplar
                    {
                        CellNumber = cellNumber,
                        RowNumber = rowNumber,
                        DateProd = new DateTime(timeList[0], timeList[1], timeList[2]),
                        CityProd = city,
                    };
                    exemplarsEntity.Add(examplar);
                }
                else
                    i--;
            }

            var supplierEntity = _productRepository.GetSupplierById(numberSupplier);

            if (supplierEntity == null)
                return false;

            var productEntity = new Product
            {
                Name = name,
                IsCertificatePresent = isCertificat,
                PriceProd = price,
                Exemplars = exemplarsEntity,
            };

            var result = _productRepository.Save(productEntity);
            if (result)
            {
                var supply = new Supply
                {
                    Product = productEntity,
                    Supplier = supplierEntity,
                    DeliveryDate = DateTime.Now,
                };

                var result2 = _productRepository.Save(supply);

                if (result2)
                    return true;
            }

            return false;
        }

        public ProductDetailsBO GetProductBySKU(int productSKU)
        {
            var product = _productRepository.GetProductBySKU(productSKU);

            var productBO = new ProductDetailsBO()
            {
                ProductSKU = product.ProductSKU,
                Name = product.Name,
                IsCertificatePresent = product.IsCertificatePresent,
                PriceProd = product.PriceProd,
                Count = product.Exemplars.Count(),
                Exemplars = product.Exemplars.Select(ex => new ProductExemplarBO
                {
                    ProductSKU = ex.ProductSKU,
                    Code = ex.Code,
                    CellNumber = ex.CellNumber,
                    RowNumber = ex.RowNumber,
                    CityProd = ex.CityProd,
                    DateProd = ex.DateProd.ToShortDateString(),
                }),
                Suppliers = GetSuppliersToString(product.Suppliers)
            };
            return productBO;
        }

        public IEnumerable<ProductBO> GetProducts()
        {
            var products = _productRepository.GetProducts();

            var productsBO = products.Select(product => new ProductBO
            {
                ProductSKU = product.ProductSKU,
                Name = product.Name,
                PriceProd = product.PriceProd,
                NumbOfCopies = product.Exemplars.Count(),
            }) ;

            return productsBO;
        }

        private List<int> GetTime(string time)
        {
            var result = new List<int>();

            var timeArr = time.Split(".").Select(t => int.Parse(t)).ToArray();

            result.Add(timeArr[2]);
            result.Add(timeArr[1]);
            result.Add(timeArr[0]);

            return result;
        }

        private string GetSuppliersToString(IEnumerable<Supplier> suppliers)
        {
            var result = new StringBuilder();

            foreach (var supplier in suppliers)
                result.Append($"{supplier.Name} ");

            return result.ToString();
        }

        public bool IssueProduct(int productSKU, int count)
        {
            var productEntity = _productRepository.GetProductBySKU(productSKU);

            if (productEntity == null)
                return false;

            if (productEntity.Exemplars.Count() < count)
                return false;

            for (int i = 0; i < count; i++)
            {
                var examplarProduct = productEntity.Exemplars.FirstOrDefault();
                _productRepository.Delete(examplarProduct);
            }

            if (productEntity.Exemplars.Count() == 0)
                _productRepository.Delete(productEntity);

            return true;
        }

        public bool AddSupplier(string nameSupplier, string addressSupplier, string phoneSupplier)
        {
            var supplierEntity = new Supplier()
            {
                Name = nameSupplier,
                Address = addressSupplier,
                Phone = phoneSupplier,
            };

            var result = _productRepository.Save(supplierEntity);
            if (result)
               return true;

            return false;
        }

        public IEnumerable<SupplierBO> GetSuppliers()
        {
            var suppliers = _productRepository.GetAllSuppliers();

            return suppliers.Select(s => new SupplierBO
            {
                Id = s.Id,
                Name = s.Name,
                Phone = s.Phone,
                Address = s.Address,
            });
        }
    }
}
