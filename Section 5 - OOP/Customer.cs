namespace Section_5___OOP;

public class Customer
{
    //Static field to hold the next ID available
    private static int nextId = 0;
    private readonly int _id;
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }

    //Read only property
    public int Id { get => _id; }
    
    private string _password;
    public string Password {  set => _password = value; }
    
    
    //Custom Constructor
    // public Customer(string name, string address, string contactNumber)
    // {
    //     Name = name;
    //     Address = address;
    //     ContactNumber = contactNumber;
    // }
    
    public Customer(string name, string address = "NA", string contactNumber = "NA")
    {
        _id = nextId++;
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }
    
    public Customer(string name)
    {
        _id = nextId++;
        Name = name;
    }

    //default constructor
    public Customer()
    {
        _id = nextId++;
        Name = "UNKNOWN";
        Address = "UNKNOWN";
        ContactNumber = "UNKNOWN";
    }
    
    
    public void SetDetails(string name, string address, string contactNumber = "NA")
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name} , Address: {Address}, ContactNumber: {ContactNumber}");
    }

    public static void DoSomethingCustomerStuff()
    {
        Console.WriteLine("Do some customer stuff");
    }

    public void GetDetalis()
    {
        Console.WriteLine($"Details about the customer: Name: {Name} and Id: {Id} and Password: {_password}");
    }
}