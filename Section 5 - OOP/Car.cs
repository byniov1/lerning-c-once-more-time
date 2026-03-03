using System.Globalization;

namespace Section_5___OOP;

public class Car
{
    private string _brand = "";
    
    public string Brand {
        get =>  IsLuxury ? _brand + " - Luxury" : _brand;
        
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You've entered NOTHIG");
                _brand = "DEFAULT_VALUE";
            }
            else
            {
                _brand = value;
            }
            
        }
    }
    public bool IsLuxury { get; set; }
    private string Model { get; set; }


    public Car(string brand, string model, bool isLuxury)
    {
        Model = model;
        Brand = brand;
        IsLuxury  = isLuxury;
        
        Console.WriteLine($"An {Brand} model {Model} has been created");
    }
}















//1
/*public class Car
{
    //member variable
    //Backing field of the Model property
    private string _brand = "";

    
    // private string _model = "";
    // private string Model { get => _model; set => _model = value; }
    
    //Property
    private string Model { get; set; }
    // private string Brand { get => _brand; set => _brand = value; }
    public string Brand {
        //0
        /*
         get
         {
            //1
            /*if (IsLuxury)
            {
                return  _brand + " - Luxury";
            }
            else
            {
                return _brand;
            }#2#
            //2 /*return IsLuxury ? _brand + " - Luxury" : _brand; 8#2#
        }#1#
        //3
        get =>  IsLuxury ? _brand + " - Luxury" : _brand;
        
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You've entered NOTHIG");
                _brand = "DEFAULT_VALUE";
            }
            else
            {
                _brand = value;
            }
            
        }
    }

    // private bool _isLuxury = false;
    // public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
    public bool IsLuxury { get; set; }


    //custom constructor
    public Car(string brand, string model, bool isLuxury)
    {
        // _model = model;
        // _brand = brand;
        Model = model;
        Brand = brand;
        IsLuxury  = isLuxury;
        
        // Console.WriteLine($"An {_brand} model {_model} has been created");
        Console.WriteLine($"An {Brand} model {Model} has been created");
    }
}*/