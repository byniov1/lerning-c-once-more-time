using System.Collections;

namespace Section_6___Collection;

class Program
{
    //1
    /*static void Main(string[] args)
    {
        // List<string> colors = new List<string>();
        // colors.Add("Red");
        // colors.Add("Blue");
        // colors.Add("Yellow");
        // colors.Add("Yellow");
        // colors.Add("Yellow");
        
        List<string> colors =
        [
            "Red",
            "Blue",
            "Yellow",
            "Yellow",
            "Yellow"
        ];
        
        
        DisplayList(colors);

        Console.WriteLine("\nI'm removing items");
        // colors.Remove("Yellow");
        // bool isDeletingSuccessfull = colors.Remove("Yellow");
        
        //delete all yellow
        //1
        // while (isDeletingSuccessfull)
        // {
        //     isDeletingSuccessfull = colors.Remove("Yellow");
        // }
        
        //2
        //Można to było uprościć ale bajka nie wiedzialem jak dorwać się do "color"
        colors.RemoveAll(color => IsGivenColor(color, "Yellow"));
        // var filteredColors = colors.Where(c => c != "Yellow").ToList();                                      !!!! HINT NA PRZYSZŁOŚĆ !!!! 
        DisplayList(colors);
    }*/

    //2
    /*static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 5, 15, 2, 3, 9, 2, 0, 2, 2 };
        DisplayList(numbers, "Numbers");
        
        numbers.Sort();
        DisplayList(numbers, "Sorted numbers");
    
        List<int>higherEqualTen = numbers.FindAll(element => element >= 10);
        DisplayList(higherEqualTen, "Numbers, greater than 10");
        
        
        // Predicate<int> isGreaterThanTen = number => number > 10;
        Predicate<int> isGreaterThanTen = IsGreaterThanTen;
        List<int>higherTen = numbers.FindAll(isGreaterThanTen);
        DisplayList(higherTen, "Numbers, greater than 10");
    
        bool isThereNumberGreaterThat20 = numbers.Any(number => number > 20);
        Console.WriteLine("isThereNumberGreaterThat20: " + isThereNumberGreaterThat20);
    }*/

    //3
    /*public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
    }
    
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product { Name = "Pepperoni", Price = 9.99 },
            new Product { Name = "Apple", Price = 5.99 },
            new Product { Name = "Banas", Price = 0.30 }
        };
        products.Add(new Product { Name = "Apple", Price = 9.99 });

        
        foreach (Product product in products)
        {
            Console.WriteLine($"Product: {product.Name} - {product.Price}");
        }
        
        
        //Linq
        List<Product> cheapProducts = products.Where(product => product.Price < 1.0).ToList();
        Console.WriteLine("\nCheap Products:");
        foreach (Product product in cheapProducts)
        {
            Console.WriteLine($"Product: {product.Name} - {product.Price}");
        }
    }

    private static void DisplayList<T>(List<T> list, string textToDisplay)
    {
        Console.WriteLine(textToDisplay);
        foreach (var element in list)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
    
    private static bool IsGivenColor(string color,  string givenColor)
    {
        return color == givenColor;
    }

    private static bool IsGreaterThanTen(int number)
    {
        return number > 10;
    }*/

    
    //4 DEPRECATED - ArrayList
    /*public static void Main(string[] args)
    {
        //Array list !!!! DEPRACATED !!!!
        ArrayList myArrayList = new ArrayList();
        ArrayList myArrayList2 = new ArrayList(100);
        
        myArrayList.Add("Hello World");
        myArrayList.Add(2);
        myArrayList.Add(2);
        myArrayList.Add(false);
        myArrayList.Add(21.37);
        myArrayList.Add(21.37);
        myArrayList.Add(128);
        myArrayList.Add(128);
        
        //Remove specyfic value from arrayList
        myArrayList2.Remove(2);
        
        //delete element at specyfic position
        myArrayList.RemoveAt(4);

        Console.WriteLine("Elements in myArrayList" + myArrayList.Count);


        double sum = 0;
        foreach (var item in myArrayList)
        {
            if (item is int)
            {
                sum += Convert.ToDouble(item);
            }
            else if (item is double)
            {
                sum += (double)(item);
            }
            else
            {
                Console.WriteLine(item);
            }
        }

        Console.WriteLine($"Sum of number: {sum}");
        
    }*/
    
    //4 DEPRECATED - HashTables ==> Dictionaries
    /*class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gpa)
        {
            ID = id;
            Name = name;
            GPA = gpa;
        }
    }
    public static void Main(string[] args)
    {
        Hashtable studentsHashTable = new Hashtable();
        
        studentsHashTable.Add(1, new Student(1, "John", 100));
        studentsHashTable.Add(2, new Student(2, "Jason", 200));
        studentsHashTable.Add(3, new Student(3, "Clara", 300));
        studentsHashTable.Add(4, new Student(4, "Steve", 400));
        
        
        Student std1 = new Student(5, "John", 200);

        Student? storedStudent1 = (Student)studentsHashTable[1];

        Console.WriteLine($"Student ID: {storedStudent1.ID}, Name: {storedStudent1.Name},  GPA: {storedStudent1.GPA}");

        // foreach (DictionaryEntry student in studentsHashTable)
        // {
        //     Student tempStudent = (Student)student.Value;
        //     Console.WriteLine($"Student ID: {tempStudent.ID}, Name: {tempStudent.Name},  GPA: {tempStudent.GPA}");
        // }
        
        //Jeżeli są Values to są także Keys
        foreach (Student student in studentsHashTable.Values)
        {
            // Student tempStudent = (Student)student.Value;
            Console.WriteLine($"Student ID: {student.ID}, Name: {student.Name},  GPA: {student.GPA}");
        }
        
        studentsHashTable.Add(std1.ID, std1);
    }*/

    //Nullables
    /*public static void Main(String[] args)
    {
        int? age = null;
        // int? age = 20;

        if (age.HasValue)
        {
            Console.WriteLine($"{age} years old");
            Console.WriteLine($"{age.Value} years old");
        }
        else
        {
            // int sum0 = age.Value + 20; //to się wywali jak age bedzie null bo chemy value z null
            int? sum1 = age + 20;
            Console.WriteLine("Age is not speciffied" + sum1);
        }
    }*/

    //Dictionaries
    public static void Main(String[] args)
    {
        //key - value;
        Dictionary<int, string> employees = new Dictionary<int, string>();
        employees.Add(101, "Bob");
        employees.Add(102, "Jill");
        employees.Add(103, "Jane");
        employees.Add(104, "Kuba");
        employees.Add(105, "Tomek");
        //To się wywali bo powtarza się key -> więc pytanie jak ładniej dodawać elementy do Dictionary
        // employees.Add(105, "Tomek");
        
        //Można tak xD ale czy to takie eleganckie nie wiem ale jest to sps
        if (!employees.ContainsKey(101))
            employees.Add(105, "Tomek");
        
        //i można to tak rozwinąć - ale to workaround
        /*
        int counter = 101;
        while (employees.ContainsKey(counter))
        {
            counter++;
        }
        employees.Add(counter, "Kuba");*/
        
        //Powinno się to robić tak
        bool added = employees.TryAdd(102, "Tomek");
        if (!added)
            Console.WriteLine("Couldn't add employee with id 102");
        
        
        
        employees.Add(106, "Mateusz");
        
        string name = employees[101];
        Console.WriteLine(name);
        
        employees[102] = "Jolie Smith";
        employees.Remove(101);

        //Tak też zadziała xD
        // foreach (var employee in employees)
        // {
        //     Console.WriteLine(employee);
        // }
        
        foreach (KeyValuePair<int, string> employee in employees)
        {
            Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
        }
    }
}