// See https://aka.ms/new-console-template for more information

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

class Program
{
    public static void Main(string[] args)
    {
        UniversityManager universityManager = new UniversityManager();
        universityManager.MaleStudents();
        universityManager.FemaleStudents();
        
    }
}

class UniversityManager
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

        foreach (Student student in maleStudents)
        {
            student.Print();
        }

        Console.WriteLine("");
    }

    public void FemaleStudents()
    {
        Console.WriteLine("Female Students");
        IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;

        foreach (Student femaleStudent in femaleStudents)
        {
            femaleStudent.Print();
        }
        
        Console.WriteLine("");
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