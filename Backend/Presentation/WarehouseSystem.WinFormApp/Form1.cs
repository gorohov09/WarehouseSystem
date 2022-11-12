using WarehouseSystem.DAL.Interfaces;

namespace WarehouseSystem.WinFormApp
{
    public partial class Form1 : Form
    {
        private readonly IProductRepository _productRepository;

        private readonly IProductExemplarRepository _productExemplarRepository;

        public Form1(IProductRepository productRepository, IProductExemplarRepository productExemplarRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _productExemplarRepository = productExemplarRepository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = _productRepository.GetProducts();
        }

        private void button_PER_test_Click(object sender, EventArgs e)
        {
            var productsExemplars = _productExemplarRepository.GetProductExemplars();
        }

        private void textBox_inputSKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_inputSKU_test_Click(object sender, EventArgs e)
        {
            var productSKU = int.Parse(textBox_inputSKU.Text);
            var product = _productRepository.GetProductBySKU(productSKU);
        }
    }
}