﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseSystem.Application.Interfaces;

namespace WarehouseSystem.WinFormApp.Forms
{
    public partial class ProductReceiveWindow : Form
    {
        private readonly IProductService _productService;

        public ProductReceiveWindow(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ProductReceive_Name_Input.Text)
                || string.IsNullOrEmpty(textBox_ProductReceive_PriceProd_Input.Text)
                || string.IsNullOrEmpty(textBox_ProductReceive_NumbOfCopies_Input.Text)
                || string.IsNullOrEmpty(textBox_ProductReceive_VendorNumber_Input.Text)
                || string.IsNullOrEmpty(textBox_ProductReceive_CityProd_Input.Text)
                || string.IsNullOrEmpty(textBox_ProductReceive_DateProd_Input.Text))
            {
                MessageBox.Show("Введи все поля");
                return;
            }


            var name = textBox_ProductReceive_Name_Input.Text;
            var price = decimal.Parse(textBox_ProductReceive_PriceProd_Input.Text);
            var count = int.Parse(textBox_ProductReceive_NumbOfCopies_Input.Text);
            var numberSupplier = int.Parse(textBox_ProductReceive_VendorNumber_Input.Text);
            var city = textBox_ProductReceive_CityProd_Input.Text;
            var date = textBox_ProductReceive_DateProd_Input.Text;

            var isCertificate = radioButton_ProductReceive_IsCertificatePresent_True.Checked;

            var result = _productService.AddProduct(name, city, date, count, price, numberSupplier, isCertificate);

            if (result)
                MessageBox.Show("Товар успешно получен!");
            else
                MessageBox.Show("Произошла ошибка!");
        }
    }
}
