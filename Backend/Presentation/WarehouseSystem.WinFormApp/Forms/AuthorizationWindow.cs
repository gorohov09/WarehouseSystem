using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseSystem.WinFormApp.Forms
{
    public partial class AuthorizationWindow : Form
    {
        private readonly MainWindow _mainWindow;

        public AuthorizationWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void button_EnterAuthorization_Click(object sender, EventArgs e)
        {
            var login = textBox_InputLogin.Text;
            var password = textBox_InputPassword.Text;

            if (login == "123" && password == "123")
            {
                this.Hide();
                _mainWindow.ShowDialog();          
            }
            else
                MessageBox.Show("Неправильный логин или пароль");
        }
    }
}
