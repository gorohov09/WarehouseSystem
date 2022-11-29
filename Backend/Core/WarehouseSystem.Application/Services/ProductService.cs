﻿using System.Text;
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
                var examplar = new ProductExemplar
                {
                    CellNumber = random.Next(1, 100),
                    RowNumber = random.Next(1, 100)
                };
                exemplarsEntity.Add(examplar);
            }

            var supplierEntity = _productRepository.GetSupplierById(numberSupplier);

            if (supplierEntity == null)
                return false;

            var productEntity = new Product
            {
                Name = name,
                DateProd = new DateTime(timeList[0], timeList[1], timeList[2]),
                CityProd = city,
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
                CityProd = product.CityProd,
                DateProd = product.DateProd.ToShortDateString(),
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
    }
}
