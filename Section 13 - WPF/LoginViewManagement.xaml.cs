using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// InvoiceManagement -> envia variable name 

namespace Section_13___WPF
{
    public partial class LoginViewManagement: UserControl
    {
        public LoginViewManagement()
        {
            InitializeComponent();
            //Albo można w xamlu
            // LoginButton.IsEnabled = false;
        }

        public void OnLogicBtnClicked(object sender, RoutedEventArgs e)
        {
            var passwordEntered = PasswordBox.Password;

            if (passwordEntered == "")
                MessageBox.Show("Please enter a password");

            string? envPw = Environment.GetEnvironmentVariable("InvoiceManagement");

            if (envPw != null)
            {
                if (passwordEntered == envPw)
                {
                    MessageBox.Show("You have successfully logged in");
                }
                else
                {
                    MessageBox.Show("Login failed");
                }
            }
            else
            {
                MessageBox.Show("Enviroment variable not found");
            }

        }

        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            LoginButton.IsEnabled = !string.IsNullOrEmpty(PasswordBox.Password);
        }
    }
}