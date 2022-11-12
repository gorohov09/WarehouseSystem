using WarehouseSystem.DAL.Interfaces;

namespace WarehouseSystem.WinFormApp
{
    public partial class Form1 : Form
    {
        private readonly IProductRepository _productRepository;

        public Form1(IProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = _productRepository.GetProducts();
        }
    }
}