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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Section_17___3___LinqToSql___2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string connectionString = ConfigurationManager.ConnectionStrings["Section_17___3___LinqToSql___2.Properties.Settings.LearningC_DBConnectionString"].ConnectionString;

            dataContext = new LinqToSqlDataClassesDataContext(connectionString);


            //InsertUniveristies();
            //InsertStudents();
            InsertLectures();
        }

        public void InsertUniveristies()
        {
            dataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);


            University beijingTech = new University();
            beijingTech.Name = "beijingTech";
            dataContext.Universities.InsertOnSubmit(beijingTech);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities.ToList();
        }

        public void InsertStudents()
        {
            //dataContext.ExecuteCommand("delete from Student");

            University yale = dataContext.Universities.First(university => university.Name.Equals("Yale"));
            University beijingTech = dataContext.Universities.First(university => university.Name.Equals("beijingTech"));
            //"from university in dataContext.University where university == "Yale" select university"

            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Carla", GENDER = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Toni", GENDER = "male", University = yale });
            students.Add(new Student { Name = "Leyle", GENDER = "female", University = beijingTech });
            students.Add(new Student { Name = "Jame", GENDER = "trans-gender", University = beijingTech });

            dataContext.Students.InsertAllOnSubmit<Student>(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;

        }


        public void InsertStudentLectureAssociations()
        {
            Student Carla = dataContext.Students.First(student => student.Name.Equals("Carla"));
            Student Toni = dataContext.Students.First(student => student.Name.Equals("Toni"));
            Student Leyle = dataContext.Students.First(student => student.Name.Equals("Leyle"));
            Student Jame = dataContext.Students.First(student => student.Name.Equals("Jame"));

            Lecture Math = dataContext.Lectures.First(lecture => lecture.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lecture => lecture.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Toni, Lecture = Math });


            StudentLecture slToni = new StudentLecture();
            slToni.Student = Toni;
            //slToni.StudentId = Toni.Id;
            slToni.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slToni);
        }

        public void GetUniversityOfToni()
        {
            Student Toni = dataContext.Students.First(student => student.Name.Equals("Toni"));
            University TonisUniversity = Toni.University;

            Console.WriteLine("Tonis Univeristy is " + TonisUniversity.Name);

            List<University> univeristies = new List<University>();
            univeristies.Add(TonisUniversity);

            MainDataGrid.ItemsSource = univeristies;
        }


        public void GetLecturesFromToni()
        {
            Student Toni = dataContext.Students.First(student => student.Name.Equals("Toni"));

            var tonisLectures = from studentLectures in Toni.StudentLectures select studentLectures.Lecture;

            MainDataGrid.ItemsSource = tonisLectures;
        }

        public void GerAllStudentsFromYale()
        {
            var studentFromYale = from student in dataContext.Students 
                                  where student.University.Name == "Yale" 
                                  select student;


            MainDataGrid.ItemsSource = studentFromYale;
        }

        public void GetAllUniversitiesWithTransgenders()
        {
            var transgengerStudents = from student in dataContext.Students
                                      join univeristy in dataContext.Universities
                                      on student.University equals univeristy
                                      where student.GENDER == "trans-gender"
                                      select univeristy;

            MainDataGrid.ItemsSource = transgengerStudents;
        }

        public void GetAllLecturesFromBeijningTech()
        {
            var lecturesFromBejingTech = from sl in dataContext.StudentLectures
                                         join student in dataContext.Students
                                         on sl.StudentId equals student.Id
                                         where student.University.Name == "Beijing Tech"
                                         select sl.Lecture;

            MainDataGrid.ItemsSource = lecturesFromBejingTech;
            
        }

        public void UpdateToni()
        {
            //var Toni = from student in dataContext.Students where student.Name == "Toni" select student;
            var Toni = dataContext.Students.FirstOrDefault(student => student.Name.Equals("Toni"));

            Toni.Name = "Antonio";
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;

            //dataContext.Students 
        }

        public void DeleteJame()
        {
            Student Jame = dataContext.Students.FirstOrDefault(student => student.Name.Equals("Jame"));
            dataContext.Students.DeleteOnSubmit(Jame);
        }

        //public void InsertStudent()
        //{

        //    var student = new Student() { Name = "James", UniversityId = 1, }
        //}


    }
}
