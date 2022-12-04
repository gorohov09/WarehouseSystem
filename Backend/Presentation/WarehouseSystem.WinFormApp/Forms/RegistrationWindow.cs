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
    public partial class RegistrationWindow : Form
    {
        private readonly IUserService _userService;

        public RegistrationWindow(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void buttonRegistration2_Click(object sender, EventArgs e)
        {
            var login = textBox_InputLoginReg.Text;
            var password = textBox_InputPasswordReg.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите все данные");
                return;
            }

            var result = _userService.Registrate(login, password);

            if (result)
                MessageBox.Show("Пользователь успешно зарегестрирован");
            else
                MessageBox.Show("Произошла ошибка. Возможно, такой пользователь уже существует");
        }
    }
}
