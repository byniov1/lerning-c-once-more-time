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

public interface IPaymentProcessor
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
}