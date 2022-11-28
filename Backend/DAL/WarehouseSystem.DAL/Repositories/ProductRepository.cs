﻿using Microsoft.EntityFrameworkCore;
using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.DAL.Models;

namespace WarehouseSystem.DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly WarehouseContext _context;

        public ProductRepository(WarehouseContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = _context.Products
                .Include(products => products.Exemplars)
                .ToList();

            return products;
        }

        public Product GetProductBySKU(int productSKU)
        {
            var product = _context.Products
                .Include(product => product.Suppliers)
                .Include(product => product.Exemplars)
                .FirstOrDefault(prod => prod.ProductSKU == productSKU);

            return product;
        }
    }
}