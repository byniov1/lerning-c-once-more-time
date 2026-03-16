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
using Section_13___WPF.Data;

namespace Section_13___WPF
{
    public partial class MainWindowListBox: UserControl
    {

        public List<Person> People = new List<Person>()
        {
            new Person { Name = "Janick", Age = 30 },
            new Person { Name = "Adam", Age = 30 },
            new Person { Name = "Kuba", Age = 25 },
            new Person { Name = "Maria", Age = 69 },
        };
        
        public MainWindowListBox()
        {
            InitializeComponent();
            //1
            /*ListBoxNames.ItemsSource = new List<string>()
            {
                "John Doe",
                "Maria Doe",
                "Peter Doe",
                "Tomasz Doe",
                "Jakub Doe",
            };*/
            
            //2
            ListBoxPeople.ItemsSource = People;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxPeople.SelectedItems;

            foreach (var item in selectedItems)
            {
                // MessageBox.Show(item.GetType().ToString());
                MessageBox.Show(item.GetType().ToString());
                // var person = item as Person;
                
                var person = (Person)item ;
                MessageBox.Show(person.Name);
            }
        }
    }
}

















