namespace Section_9___Interface;

public interface IAnimal
{
    void MakeSound();
    void Eat(string food);
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

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.MakeSound();
        dog.Eat("Treat");
    }
}