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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // 1
        /*public MainWindow()
        {
            InitializeComponent();

            //1
            /*Button myButton = new Button();
            myButton.Content = "B";
            
            Grid.SetRow(myButton, 3);
            Grid.SetColumn(myButton, 4);
            
            Grid MyGrid = FindName("MyGrid") as Grid;
            MyGrid.Children.Add(myButton);#1#
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }*/

        // public string TodoInput { get; set; }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTodoButton_Click(object sender, RoutedEventArgs e)
        {
            string todoText = TodoInput.Text;

            //Validation
            if (!string.IsNullOrEmpty(todoText))
            {
                // TextBlock todoItem = new TextBlock();
                // todoItem.Text = todoText;
                TextBlock todoItem = new TextBlock
                {
                    Text = todoText,
                };
                
                TodoList.Children.Add(todoItem);
                
                TodoInput.Clear();
            }
        }
    }
}
