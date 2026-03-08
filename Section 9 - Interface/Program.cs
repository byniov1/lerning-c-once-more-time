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
        throw new NotImplementedException();
    }

    public void Eat(string food)
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
    }
}