namespace Section_5___OOP;

public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    
    
    //Custom Constructor
    // public Customer(string name, string address, string contactNumber)
    // {
    //     Name = name;
    //     Address = address;
    //     ContactNumber = contactNumber;
    // }
    
    public Customer(string name, string address = "NA", string contactNumber = "NA")
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }
    
    public Customer(string name)
    {
        Name = name;
    }

    //default constructor
    public Customer()
    {
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
}