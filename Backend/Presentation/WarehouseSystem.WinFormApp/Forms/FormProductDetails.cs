using System;
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
    public partial class FormProductDetails : Form
    {
        private readonly IProductService _productService;

        public int ProductId { get; set; }

        public FormProductDetails(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void FormProductDetails_Load(object sender, EventArgs e)
        {
            var productDetails = _productService.GetProductBySKU(ProductId);
            label1.Text = productDetails.Name;
            label2.Text = productDetails.CityProd;
            label3.Text = productDetails.ProductSKU.ToString();
        }
    }
}
