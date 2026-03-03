using System.Globalization;

namespace Section_5___OOP;

public class Car
{
    //member variable
    private string _model = "";
    private string _brand = "";
    
    //custom constructor
    public Car(string brand, string model)
    {
        _brand = brand;
        _model = model;
        Console.WriteLine($"An {_brand} model {_model} has been created");
    }
}