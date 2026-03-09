namespace Section_5___OOP;

public class Rectangle
{
    private const int NumberOfCorners = 4;
    private readonly string Color;
    
    public double Width { get; set; }
    public double Height { get; set; }
    
    //Computed properties
    public double Area => Width * Height;

    public Rectangle(string color)
    {
        Color = color;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Color: {Color} Width: {Width} Height: {Height} Area: {Area} NumberOfCorners: {NumberOfCorners}");
    }
}