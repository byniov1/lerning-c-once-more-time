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

namespace Section_13___WPF
{
    public partial class LoginView: UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            
            // window.Content = new InvoiceView();
            // window.Content = new MainWindowForm();
            // window.Content = new MainWindowListBox();
            window.Content = new LoginViewManagement();
        }
    }
}