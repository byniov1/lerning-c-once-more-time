namespace Section_10___Structs;

public struct Point
{
    // public int X { get; set; }
    // public int Y { get; set; }
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    
    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
        // Console.SetCursorPosition(X, Y);
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.Write("P0: ");
        Point p0 = new Point();
        p0.Display();
        
        
        Console.Write("P1: ");
        Point p1 = new Point(1, 1);
        p1.Display();
       
        
        Console.Write("P2: ");
        //Do tego potrzebujemy fileds nie props
        Point p2;
        p2.X = 10;
        p2.Y = 20;
        p2.Display();

        //Tutaj widać że jest podawany value a nie reference
        Console.Write("P3: ");
        Point p3 = p1;
        p3.X = 50;
        p3.Y = 100;
        p3.Display();
        
        
        Console.Write("P1: ");
        p1.Display();

    }
}