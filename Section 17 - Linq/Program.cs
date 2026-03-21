// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Immutable;

namespace Section_17___Linq;

//1
/*internal class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5, 3, 2 };

        OddNumbers(numbers);
    }

    static void OddNumbers(int[] numbers)
    {
        Console.WriteLine("Odd Numbers");
        IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

        Console.WriteLine(oddNumbers);

        foreach (int number in oddNumbers)
        {
            Console.Write(number + " ");
        }
    }

}*/

internal class Program
{
    public static void Main(string[] args)
    {
        var universityManager = new UniversityManager();
        universityManager.MaleStudents();
        universityManager.FemaleStudents();
        universityManager.SortStudentByAge();
        universityManager.AllStudentsFromBeijningTech();


        Console.Write("Write univeristy id: ");
        // int universityId = int.Parse(Console.ReadLine()!);
        int universityId = Convert.ToInt16(Console.ReadLine()!);
        universityManager.allStudentsFromGivenUniversity(universityId);

        int[] someInt = { 30, 12, 4, 3, 12, 9 };
        IEnumerable<int> sortedInts = from i in someInt orderby i select i;
        IEnumerable<int> reversedInts = sortedInts.Reverse();
        

        foreach (int i in reversedInts)
        {
            Console.WriteLine(i);
        }
        
        IEnumerable<int> reversedSortedInts = from i in someInt orderby i descending select i;
        
    }
}

internal class UniversityManager
{
    public List<University> universities;
    public List<Student> students;

    public UniversityManager()
    {
        universities = new List<University>();
        students = new List<Student>();

        //Let's add some Universities
        universities.Add(new University { Id = 1, Name = "Yale" });
        universities.Add(new University { Id = 2, Name = "Beijing Tech" });

        //Let's add some Students
        students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
        students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
        students.Add(new Student { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
        students.Add(new Student { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
        students.Add(new Student { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        students.Add(new Student { Id = 5, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
    }

    public void MaleStudents()
    {
        Console.WriteLine("Male Students");
        IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;

        foreach (var student in maleStudents) student.Print();

        Console.WriteLine("");
    }

    public void FemaleStudents()
    {
        Console.WriteLine("Female Students");
        IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;

        foreach (var femaleStudent in femaleStudents) femaleStudent.Print();

        Console.WriteLine("");
    }

    public void SortStudentByAge()
    {
        Console.WriteLine("Students ordered by age");
        IOrderedEnumerable<Student> sortedStudents = from student in students orderby student.Age select student;

        foreach (var student in sortedStudents) student.Print();

        Console.WriteLine("");
    }

    public void AllStudentsFromBeijningTech()
    {
        Console.WriteLine("Students from Beijing Tech");
        
        IEnumerable<Student> bjtStudents = from student in students
            join university in universities on student.UniversityId equals university.Id
            where university.Name == "Beijing Tech"
            select student;

        foreach (Student student in bjtStudents)
        {
            student.Print();
        }
        Console.WriteLine("");
    }

    public void allStudentsFromGivenUniversity(int universityId)
    {
        Console.WriteLine($"All students from university Id: {universityId}");
        
        IEnumerable<Student> studentdFromGivenUniversity = from student in students
            join university in universities on student.UniversityId equals university.Id
            where university.Id == universityId
            select student;


        foreach (Student student in studentdFromGivenUniversity)
        {
            student.Print();
        }
        
        Console.WriteLine("");
    }

    public void StudentsAndUnviersityCollection()
    {
        var newCollection = from student in students
            join university in universities on student.UniversityId equals university.Id
            orderby student.Name
            select new
            {
                StudentName = student.Name,
                UniversityName = university.Name
            };

        Console.WriteLine("New Collection:");
        foreach (var col in newCollection)
        {
            Console.WriteLine($"Student {col.StudentName} from University {col.UniversityName}");
        }
    }
    
}

internal class University
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Print()
    {
        Console.WriteLine("University {0} with id {1}", Name, Id);
    }
}

internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

// Foreign Key
    public int UniversityId { get; set; }

    public void Print()
    {
        Console.WriteLine("Student {0} with id {1} Gender {2} and Age {3} from Unviersity with the Id {4}", Name, Id,
            Gender, Age, UniversityId);
    }
}