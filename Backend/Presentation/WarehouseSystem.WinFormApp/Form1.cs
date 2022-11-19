using WarehouseSystem.Application.Interfaces;
using WarehouseSystem.DAL.Interfaces;

namespace WarehouseSystem.WinFormApp
{
    public partial class Form1 : Form
    {

        private readonly IProductService _productService;
        private readonly IProductExemplarService _productExemplarService;

        public Form1(IProductService productService, IProductExemplarService productExemplarService)
        {
            InitializeComponent();
            _productService = productService;
            _productExemplarService = productExemplarService;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = _productService.GetProducts();
        }

        private void button_PER_test_Click(object sender, EventArgs e)
        {
            var productsExemplars = _productExemplarService.GetProductExemplars();
        }

        private void textBox_inputSKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_inputSKU_test_Click(object sender, EventArgs e)
        {
            var productSKU = int.Parse(textBox_inputSKU.Text);
            var product = _productService.GetProductBySKU(productSKU);
        }
    }
}