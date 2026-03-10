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
/*
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
        for (int i=0; i < people.Length - 1; i++)
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
    {
        Person[] people =
        {
            new Person { Age = 25, Name = "Bob" },
            new Person { Age = 19, Name = "Alice" },
            new Person { Age = 2, Name = "Zenon" },
            new Person { Age = 30, Name = "Jill" },
        };
        foreach (var person in people)
        {
            Console.Write($"{person.Name} - {person.Age}   - ");
        }

        Console.WriteLine("");
        
        
        PersonSorter sorter = new PersonSorter();
        sorter.Sort(people, CompareByAge);

        Console.WriteLine("\nUsing sorting by age");
        foreach (var person in people)
        {
            Console.Write($"{person.Name} - {person.Age}   - ");
        }

        Console.WriteLine();
        
        
        sorter.Sort(people, CompareByName);
        Console.WriteLine("\nUsing sorting by Name");
        foreach (var person in people)
        {
            Console.Write($"{person.Name} - {person.Age}   - ");
        }
        Console.WriteLine();
        
        
        
        
    }

    static int CompareByAge(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age);
    }

    static int CompareByName(Person x, Person y)
    {
        return String.CompareOrdinal(x.Name, y.Name);
    }
}
*/



//5  Multicast delegate
/*
public delegate void LogHandler(string message);

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

        //Creating multicast delegate
        LogHandler logHandler = logger.LogToConsole;
        // logHandler += logger.LogToFile;

        // invoking a multicast delegate
        logHandler("Hello World");


        //remove multicast
        /*logHandler -= logger.LogToFile;
        logHandler("After removing LogToFile");#1#
        
        // InvokeSafely(logHandler, "After removing LogToFile");

        foreach (LogHandler handler in logHandler.GetInvocationList())
        {
            try
            {
                handler("Event occured with error handling");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: " + e.Message);
            }
        }
        
        //Usuńmy bezpiecznie
        //Zamiast dego
        /*logHandler -= logger.LogToFile;
        logHandler("After removing LogToFile");#1#

        if (IsMethodinDelegate(logHandler, logger.LogToFile))
        {
            logHandler -= logger.LogToFile;
            Console.WriteLine("LogToFile method was removed");
        }
        else
        {
            Console.WriteLine("LogToFile method not found");
        }
        
        InvokeSafely(logHandler, "After removing LogToFile");
        
        
    }

    static void InvokeSafely(LogHandler logHandler, string message)
    {
        LogHandler tempLogHandler = logHandler;
        if (tempLogHandler != null)
        {
            tempLogHandler(message);
        }
    }

    static bool IsMethodinDelegate(LogHandler logHandler, LogHandler method)
    {
        Console.WriteLine();
        if (logHandler == null)
        {
            return false;
        }

       
        //d is delegate
        foreach (var d in logHandler.GetInvocationList())
        {
            Console.WriteLine($"Delegate: {d}");
            Console.WriteLine($"Method: {method}");
            if(d == (Delegate)method)
            {
                Console.WriteLine();
                return true;
            }
        }
        
        Console.WriteLine();
        return false;
    }
}
*/

//6 - Events
/*public delegate void Notify(string message);

public class EventPublisher
{
    // The "On" prefix makes it immediately clear that the method
    // is associated with an event.
    //It signifies that the method is not just a regular method but
    //one that is called when a specific event occurs.
    public event Notify OnNotify;

    public void RaiseEvent(string message)
    {
        OnNotify?.Invoke(message); //Invoke the event if there is anything
    }
}

public class EventSubscriber
{
    public void OnEventRaisedMethod(string message)
    {
        Console.WriteLine("Event received " + message);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        EventPublisher publisher = new EventPublisher();
        EventSubscriber subscriber = new EventSubscriber();
        publisher.OnNotify += subscriber.OnEventRaisedMethod;
        
        publisher.RaiseEvent("Hello World");
    }
}*/

//7 - Events - part 2 
class Program
{
    static void Main(string[] args)
    {}
}










































