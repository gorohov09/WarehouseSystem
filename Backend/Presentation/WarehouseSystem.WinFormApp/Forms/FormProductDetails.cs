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
            label14.Text = productDetails.ProductSKU.ToString();
            label15.Text = productDetails.Name;
            label16.Text = productDetails.CityProd;
            label17.Text = productDetails.DateProd.ToShortDateString();
            label18.Text = productDetails.PriceProd.ToString();
            label20.Text = productDetails.NumbOfCopies.ToString();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = productDetails.ExemplarsDTO;
        }
    }
}
