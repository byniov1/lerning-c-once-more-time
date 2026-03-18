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
using System.Data.SqlClient;
using System.Data;

namespace Section_15___Database
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["Section_15___Database.Properties.Settings.testDBConnectionString"].ConnectionString; 
            sqlConnection = new SqlConnection(connectionString);
            ShowZoos(sqlConnection);

            //"Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True";
            //Data Source = NBAHIRNY; Initial Catalog = testDB; Integrated Security = True; Encrypt = True; Trust Server Certificate = True     testDBConnectionString
        }

        private void ShowZoos(SqlConnection sqlConnection)
        {
            try
            {
                string query = "SELECT * FROM Zoo";

                // the SqlDataAdapter can be imagined like an Interface to make Tables usable by C#-Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();

                    sqlDataAdapter.Fill(zooTable);

                    //Which Information of the Table in DataTable should be shown in our ListBox?
                    listZoos.DisplayMemberPath = "Location";
                    //Which Value should be delivered, when an Item from our ListBox is selected?
                    listZoos.SelectedValuePath = "Id";
                    //The Reference to the Data the ListBox should populate
                    listZoos.ItemsSource = zooTable.DefaultView;

                    //foreach (DataRow row in zooTable.Rows)
                    //{
                    //    string name = row["Name"].ToString();
                    //    string location = row["Location"].ToString();
                    //    MessageBox.Show($"Name: {name}, Location: {location}");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

            //SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //    while (sqlDataReader.Read())
            //    {
            //        string name = sqlDataReader["Name"].ToString();
            //        string location = sqlDataReader["Location"].ToString();
            //        MessageBox.Show($"Name: {name}, Location: {location}");
            //    }

            //    sqlDataReader.Close();
        }


        private void ShowAssociatedAnimals()
        {
            try
            {
                string query = "SELECT * FROM Animal animal inner join ZooAnimal zooAnimal where animal.id = zooAnimal.id = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {

                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);

                    DataTable animalTable = new DataTable();

                    sqlDataAdapter.Fill(animalTable);

                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    listAssociatedAnimals.SelectedValuePath = "Id";
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listZoos.SelectedValue != null)
            {
                ShowAssociatedAnimals();
            }
        }
    }
}
