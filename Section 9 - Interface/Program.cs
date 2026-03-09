namespace Section_9___Interface;

//1
/*public interface IAnimal
{
    void MakeSound();
    void Eat(string food);
    // string Eat(string food);
    // string Eat(string food);
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Wof wof");
    }

    public void Eat(string food)
    {
        Console.WriteLine("Dog ate" + food);
    }
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meao");
    }

    public void Eat(string food)
    {
        Console.WriteLine("Cat eat" + food);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.MakeSound();
        dog.Eat("Treat");
        
        Cat cat = new Cat();
        cat.MakeSound();
        cat.Eat("Treat");
    }
}*/

//2
/*public class Animal
{
    public virtual void MakeSound()
    {
        //Hmm to jest fajne 
        Console.WriteLine($"{this.GetType().Name} MakeSound");
        Console.WriteLine("Some generic animal sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"Meow");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog();
        dog.MakeSound();
    }
}*/


//3
/*public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount} amount");
        // Implement card payment logic
    }
}

public class PayPalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal card payment of {amount} amount");
        // Implement Pall payment logic
    }
}

public class PaymentService
{
    private readonly IPaymentProcessor _processor;

    public PaymentService(IPaymentProcessor processor)
    {
        _processor = processor;
    }

    public void ProcessOrderPayment(decimal amount)
    {
        _processor.ProcessPayment(amount);
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
        PaymentService paymentService = new PaymentService(creditCardProcessor);
        paymentService.ProcessOrderPayment(100);
        
        IPaymentProcessor payPalProcessor = new PayPalProcessor();
        PaymentService payPalService = new PaymentService(payPalProcessor);
        payPalService.ProcessOrderPayment(100);
    }
}*/


//4
/*public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("FILE LOGER");
        
        
        // string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //The @ sign in c# is used to denote a verbatim string literal
        string directoryPath = @"C:\0 - Dysk D\[03] Nauka\[03] Udemy\C#\Logs";
        string filePath = System.IO.Path.Combine(directoryPath, "log.txt");
        // File.AppendAllText("log.txt", "Hello World! \n");
        // message = "This is a log entry \n";

        if (!Directory.Exists(directoryPath))
            Directory.CreateDirectory(directoryPath);
        
        // File.AppendAllText(filePath, "Hello World! \n");
        File.AppendAllText(filePath, message);
    }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to databse. {message}");
    }
}

public class Application
{
    private readonly ILogger _logger;

    public Application(ILogger logger)
    {
        _logger = logger;
    }

    public void DoWork()
    {
        Console.WriteLine("APPLICATION LOGER");
        _logger.Log("Work started");
        //Do all the work
        _logger.Log("Good JOOB");
        
    }
}

class Program
{
    public static void Main(string[] args)
    {

        ILogger fileLogger = new FileLogger();
        Application application = new Application(fileLogger);
        application.DoWork();

        Console.WriteLine();
        
        ILogger dbLoger = new DatabaseLogger();
        Application application1 = new Application(dbLoger);
        application1.DoWork();
    }
}*/

//5 Dependency
/*
public class Hammer
{
    public void Use()
    {
        Console.WriteLine("Hammering Nails");
    }
}

public class Saw
{
    public void Use()
    {
        Console.WriteLine("Sawing wood!");
    }
}

public class Builder
{
    private Hammer _hammer;
    private Saw _saw;

    //Builder DEPENDS on the hammer and the saw -> saw and the hammer are the dependencies
    public Builder()
    {
        _hammer = new Hammer(); //Builder is responsible for creating its dependencies;
        _saw = new Saw();
    }

    public void BuildHouse()
    {
        _hammer.Use();
        _saw.Use();
        Console.WriteLine("House Built");
    }
}

public class Program
{
    public static void Main()
    {}
}
*/

//Dependency Injection -> Patrz na przykład wcześniej jak to wyglądało 
public class Hammer
{
    public void Use()
    {
        Console.WriteLine("Hammering Nails");
    }
}

public class Saw
{
    public void Use()
    {
        Console.WriteLine("Sawing wood!");
    }
}

public class Builder
{
    private Hammer _hammer;
    private Saw _saw;

    // Constructor Dependency Injection
    public Builder(Hammer hammer, Saw saw)
    {
        _hammer = hammer;
        _saw = saw;
    }

    public void BuildHouse()
    {
        _hammer.Use();
        _saw.Use();
        Console.WriteLine("House Built");
    }
}

public class Program
{
    public static void Main()
    {
        Hammer hammer = new Hammer();
        Saw saw = new Saw();
        Builder builder = new Builder(hammer, saw);
        builder.BuildHouse();
    }
}