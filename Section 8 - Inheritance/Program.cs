using Microsoft.VisualBasic.CompilerServices;

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
/*
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
*/

//5
/*class Program
{
    private static void Main(string[] args)
    {
        // Employee e1 = new Employee("John Doe", 10, "Sales Rep", 1324);
        // e1.DisplayEmployeeInf();

        Manager carl = new Manager("carl", 45, "Manager", 1233, 5);
        carl.DisplayManagerInfo();
        carl.BecomeOlder(5);
        carl.DisplayManagerInfo();

        
        // carl.Equals()
    }
}



public class Person
{
    private string Name { get; set; }
    private int  Age { get; set; }
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Person constructor called");
    }

    public void DisplayPersonInformation()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    
    /// <summary>Makes our object older.</summary>
    /// <param name="years">The parameter thaht indicates the amount of years the object should age.</param>
    /// <returns>>Returns the new age after aging/becoming older .</returns>
    public int BecomeOlder(int years)
    {
        return Age += years;
    }
}

// public sealed class Employee : Person
public class Employee : Person
{
    public string  JobTitle { get; set; }
    public int EmployeeId { get; set; }
    
    public Employee(string name, int age, string jobTitle, int employeeId) : base(name, age)
    {
        //Ciekawe jak coś takiego zrobić żeby działało 
        name = $"Employee {name}";

        JobTitle = jobTitle;
        EmployeeId = employeeId;
        Console.WriteLine("Employe e constructor called");
    }

    public void DisplayEmployeeInf()
    {
        DisplayPersonInformation();
        Console.WriteLine("JobTitle: " + JobTitle + " Employee ID: " + EmployeeId);
    }
}


public class Manager: Employee
{
    public int TeamSize { get; set; }
    public Manager(string name, int age, string jobTitle, int employeeId, int teamSize) : base(name, age, jobTitle, employeeId)
    {
        TeamSize = teamSize;
        Console.WriteLine("Manager  constructor called");
    }

    public void DisplayManagerInfo()
    {
        DisplayEmployeeInf();
        Console.WriteLine("Team size: " + TeamSize);
    }
}*/