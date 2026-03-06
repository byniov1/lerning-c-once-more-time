namespace Section_8___Inheritance;

//1
/*class Program
{

static void Main(string[] args)
    {
        Animal animal = new Animal();   //Eat()
        Animal dog = new Dog();         //Dalej tylko Eat()
        Dog dog2 = new Dog();           //Tutaj już Eat() i Bark()

        animal.Eat();
        dog.Eat();
        dog2.Eat();
        dog2.Bark();
    }
}

//Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

//Derived Class(Child class or Subclass)
class Dog: Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

//Mulit level inheritance
//A breed of Dog
class Collie : Dog
{
    public void GoingNuts()
    {
        Console.WriteLine("Colie going nuts....");
    }
}


//Hierarchiczne dziedziczenie
class Cat : Animal
{
    public void Miau()
    {
        Console.WriteLine("Cat is miauing");
    }
}
*/

//2
/*class Program
{
    private static void Main(string[] args)
    {
        BaseClass baseClass = new BaseClass();
        baseClass.ShowField();
        
        
        DerivedClass derivedClass = new DerivedClass();
        derivedClass.AccessFields();
        derivedClass.ShowField();
    }
}

class BaseClass
{
    public int publicField;
    protected int protectedField;
    private int privateField;

    public void ShowField()
    {
        Console.WriteLine($"PublicField: {publicField}, ProtectedField: {protectedField}, PrivateField: {privateField}" );
    }
}

class DerivedClass : BaseClass
{
    public void AccessFields()
    {
        publicField = 1;
        protectedField = 2;
        // privateFiled = 3;
    }
}*/


//3
class Program
{

    static void Main(string[] args)
    {
        Animal animal = new Animal(); 
        Dog dog = new Dog();           
        Cat cat = new Cat();
        
        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();
        
        
    }
}

//Base class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Making sound");
    }
}

class Dog: Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Barking...");
        base.MakeSound();
    }
}

class Cat : Animal
{
    public void MakeSound()
    {
        Console.WriteLine("Cat is miauing");
    }
}
