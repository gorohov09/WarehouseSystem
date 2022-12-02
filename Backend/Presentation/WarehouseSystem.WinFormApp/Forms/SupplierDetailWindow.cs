using WarehouseSystem.Application.Interfaces;

namespace WarehouseSystem.WinFormApp.Forms
{
    public partial class SupplierDetailWindow : Form
    {
        private readonly IProductService _productService;

        public SupplierDetailWindow(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
        }

        private void SupplierDetailWindow_Load(object sender, EventArgs e)
        {
            dataGridView_SupplierDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_SupplierDetail.AllowUserToAddRows = false;
            dataGridView_SupplierDetail.ReadOnly = true;
            dataGridView_SupplierDetail.DataSource = _productService.GetSuppliers().ToList();
            dataGridView_SupplierDetail.Columns[0].HeaderText = "Id";
            dataGridView_SupplierDetail.Columns[1].HeaderText = "Имя";
            dataGridView_SupplierDetail.Columns[2].HeaderText = "Адресс";
            dataGridView_SupplierDetail.Columns[3].HeaderText = "Телефонный номер";
        }
    }
}
