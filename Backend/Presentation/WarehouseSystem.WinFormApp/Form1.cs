using WarehouseSystem.Application.Interfaces;
using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.WinFormApp.Forms;

namespace WarehouseSystem.WinFormApp
{
    public partial class Form1 : Form
    {

        private readonly IProductService _productService;
        private readonly IProductExemplarService _productExemplarService;
        private readonly FormProductDetails _formProductDetails;

        public Form1(IProductService productService, IProductExemplarService productExemplarService, FormProductDetails formProductDetails)
        {
            InitializeComponent();
            _productService = productService;
            _productExemplarService = productExemplarService;
            _formProductDetails = formProductDetails;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = _productService.GetProducts().ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //При клике на товар, мы будем открывать новое окно, где будет отображаться детальная информация по товару 
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                _formProductDetails.ProductId = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                _formProductDetails.ShowDialog();
            }
        }
    }
}