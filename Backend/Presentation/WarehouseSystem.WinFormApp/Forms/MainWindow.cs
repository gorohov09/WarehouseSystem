﻿using WarehouseSystem.Application.Interfaces;

namespace WarehouseSystem.WinFormApp.Forms
{
    public partial class MainWindow : Form
    {
        private readonly IProductService _productService;
        private readonly ProductDetailWindow _productDetailWindow;
        private readonly ProductReceiveWindow _productReceiveWindow;
        private readonly ProductsIssueWindow _productsIssueWindow;

        public MainWindow(IProductService productService, ProductDetailWindow productDetailWindow, 
            ProductReceiveWindow productReceiveWindow, ProductsIssueWindow productsIssueWindow)
        {
            _productService = productService;
            _productDetailWindow = productDetailWindow;
            _productReceiveWindow = productReceiveWindow;
            _productsIssueWindow = productsIssueWindow;
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = _productService.GetProducts().ToList();
            dataGridView1.Columns[0].HeaderText = "Артикул";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Цена";
            dataGridView1.Columns[3].HeaderText = "Колличество";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                var obj = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                _productDetailWindow.ProductId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                _productDetailWindow.ShowDialog();
            }
        }

        private void button_AddProductAxemplar_Click(object sender, EventArgs e)
        {
            _productReceiveWindow.ShowDialog();
        }

        private void button_IssueProduct_Click(object sender, EventArgs e)
        {
            _productsIssueWindow.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.GetProducts().ToList();
        }
    }
}