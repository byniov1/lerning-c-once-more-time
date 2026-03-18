using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Section_15___Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Section_15___Database.Properties.Settings.testDBConnectionString"].ConnectionString; 
            
            //"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True";
            //Data Source = NBAHIRNY; Initial Catalog = testDB; Integrated Security = True; Encrypt = True; Trust Server Certificate = True     testDBConnectionString
        }
    }
}
