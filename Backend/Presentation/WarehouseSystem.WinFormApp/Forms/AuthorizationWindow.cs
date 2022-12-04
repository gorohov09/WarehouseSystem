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
    public partial class AuthorizationWindow : Form
    {
        private readonly MainWindow _mainWindow;
        private readonly RegistrationWindow _registrationWindow;
        private readonly IUserService _userService;

        public AuthorizationWindow(MainWindow mainWindow, RegistrationWindow registrationWindow,
            IUserService userService)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _registrationWindow = registrationWindow;
            _userService = userService;
        }

        private void button_EnterAuthorization_Click(object sender, EventArgs e)
        {
            var login = textBox_InputLogin.Text;
            var password = textBox_InputPassword.Text;

            var result = _userService.Authorize(login, password);

            if (result)
            {
                this.Hide();
                _mainWindow.ShowDialog();          
            }
            else
                MessageBox.Show("Неправильный логин или пароль");
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            _registrationWindow.ShowDialog();
        }
    }
}
