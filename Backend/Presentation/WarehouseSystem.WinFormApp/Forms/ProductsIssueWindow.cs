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
    public partial class ProductsIssueWindow : Form
    {
        private readonly IProductService _productService;

        public ProductsIssueWindow(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
        }

        private void dataGridView_ProductsIssue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button_IssueProductsExemplars_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_InputProductSKU.Text) || string.IsNullOrEmpty(textBox_InputProductsExemplarsCount.Text))
            {
                MessageBox.Show("Введите все поля");
                return;
            }

            var productSKU = int.Parse(textBox_InputProductSKU.Text);
            var counyProductExamplar = int.Parse(textBox_InputProductsExemplarsCount.Text);
            var result = _productService.IssueProduct(productSKU, counyProductExamplar);

            if (result)
                MessageBox.Show("Товар успешно поставлен");
            else
                MessageBox.Show("Произошла ошибка");
        }

        private void ProductsIssueWindow_Load(object sender, EventArgs e)
        {
            dataGridView_ProductsIssue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_ProductsIssue.AllowUserToAddRows = false;
            dataGridView_ProductsIssue.ReadOnly = true;
            dataGridView_ProductsIssue.DataSource = _productService.GetProducts().ToList();
            dataGridView_ProductsIssue.Columns[0].HeaderText = "Артикул";
            dataGridView_ProductsIssue.Columns[1].HeaderText = "Название";
            dataGridView_ProductsIssue.Columns[2].HeaderText = "Цена";
            dataGridView_ProductsIssue.Columns[3].HeaderText = "Колличество";
        }
    }
}
