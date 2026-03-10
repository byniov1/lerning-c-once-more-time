namespace Section_11___Delegates;

//1 Delegates init
/*
class Program
{
    // 1. Declaration:I
    public delegate void Notify(string message);

    static void Main(string[] args)
    {
        //Delegates define a method signature,
        //and any method assigned to a delegate must match this signature

        // 2. Instantiation:
        //New way
        Notify notifyDelegate = ShowMessage;
        //Old way
        Notify notifyDelegate2 = new Notify(notifyDelegate);

        // 3. Invocation:
        notifyDelegate("This is first delegate");
        notifyDelegate2("This is second delegate");
    }

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
*/

//2 Delagates
/*public delegate void LogHandler(string message);

public class Logger
{
    public void LogToConsole(string message)
    {
        Console.WriteLine($"Console Log:  {message}");
    }

    public void LogToFile(string message)
    {
        Console.WriteLine($"File Log: {message}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        var logger = new Logger();

        LogHandler logHandler = logger.LogToConsole;
        logHandler("Using delegates!");

        logHandler = logger.LogToFile;
        logHandler("Using delegates!");
    }
}*/

//3 Generics
/*internal class Program
{
    public static void PrintIntArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        
        Console.WriteLine("");
    }

    public static void PrintStringArray(string[] array)
    {
        foreach (string item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("");
    }

    public static void PrintArray<T>(T[] array)
    {
        foreach (T item in array) Console.Write(item + " ");
    }

    private static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        string[] stringArray = { "Hello", "World", "Hello", "World" };
        PrintIntArray(intArray);
        PrintStringArray(stringArray);

        Console.WriteLine("\nGeneric Method");
        PrintArray(intArray);
        PrintArray(stringArray);
    }
}*/



//Delagtes generic and classes
public delegate int Comparision<T>(T x, T y);

public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}

public class PersonSorter
{
    public void Sort(Person[] people, Comparision<Person> comparision)
    {
        for (int i = 0; i < people.Length - 1; i++)
        {
            for (int j = i + 1; j < people.Length; j++)
            {
                //Simple bublesort
                if (comparision(people[i], people[j]) > 0)
                {
                    // Person temp = people[i];
                    // people[i] = people[j];
                    // people[j] = temp;
                    //This is the same as code above
                    (people[i], people[j]) = (people[j], people[i]);
                }
            }
        }
    }
}


class Program
{
    static void Main(string[] args)
    {}
}