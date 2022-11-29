using WarehouseSystem.Application.Interfaces;

namespace WarehouseSystem.WinFormApp.Forms
{
    public partial class ProductDetailWindow : Form
    {
        private readonly IProductService _productService;

        //Поле, в которое устанавливаем ProductID
        public int ProductId { get; set; }

        public ProductDetailWindow(IProductService productService)
        {
            _productService = productService;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetailWindow_Load(object sender, EventArgs e)
        {
            var productBO = _productService.GetProductBySKU(ProductId);

            dataGridView_ProductDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_ProductDetail.AllowUserToAddRows = false;
            dataGridView_ProductDetail.ReadOnly = true;
            dataGridView_ProductDetail.DataSource = productBO.Exemplars.ToList();

            dataGridView_ProductDetail.Columns[0].HeaderText = "Номер";
            dataGridView_ProductDetail.Columns[1].HeaderText = "Артикул";
            dataGridView_ProductDetail.Columns[2].HeaderText = "Номер ряда";
            dataGridView_ProductDetail.Columns[3].HeaderText = "Номер ячейки";

            label_ProductDetail_ProductSKU_Output.Text = productBO.ProductSKU.ToString();
            label_ProductDetail_PriceProd_Output.Text = productBO.PriceProd.ToString();
            label_ProductDetail_NumbOfCopies_Output.Text = productBO.Count.ToString();
            label_ProductDetail_IsCertificatePresent_Output.Text = productBO.IsCertificatePresent.ToString();
            label_ProductDetail_DateProd_Output.Text = productBO.DateProd.ToString();
            label_ProductDetail_CityProd_Output.Text = productBO.CityProd.ToString();
            label_ProductDetail_Name_Output.Text = productBO.Name.ToString();
            label_ProductDetail_VendorNumber_Output.Text = productBO.Suppliers.ToString();
        }
    }
}
