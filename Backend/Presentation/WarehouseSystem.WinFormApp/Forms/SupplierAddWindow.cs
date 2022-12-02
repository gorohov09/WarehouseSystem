using WarehouseSystem.Application.Interfaces;


namespace WarehouseSystem.WinFormApp.Forms
{
    public partial class SupplierAddWindow : Form
    {
        private readonly IProductService _productService;

        public SupplierAddWindow(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private void button_SupplierAddWindow_AddSupplier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SupplierAddWindow_Name_Input.Text)
                || string.IsNullOrEmpty(textBox_SupplierAddWindow_Address_Input.Text)
                || string.IsNullOrEmpty(textBox_SupplierAddWindow_Phone_Input.Text))
            {
                MessageBox.Show("Введите все данные");
                return;
            }

            var nameSupplier = textBox_SupplierAddWindow_Name_Input.Text;
            var addressSupplier = textBox_SupplierAddWindow_Address_Input.Text;
            var phoneSupplier = textBox_SupplierAddWindow_Phone_Input.Text;

            var result = _productService.AddSupplier(nameSupplier, addressSupplier, phoneSupplier);

            if (result)
                MessageBox.Show("Поставщик успешно добавлен");
            else
                MessageBox.Show("Поставщик не добавлен");
        }
    }
}
