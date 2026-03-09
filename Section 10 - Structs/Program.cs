namespace Section_10___Structs;

public struct Point
{
    //Jest częstą praktyką że structs robi się immutable by declaring all fields as readonly and providing only get accessors for props
    // public int X { get; set; }
    // public int Y { get; set; }
    // public int X;
    // public int Y;
    public double X { get;  }
    public double Y { get; }
    
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

    public double DistanceTo(Point other)
    {
        double dx = other.X - X;
        double dy = other.Y - Y;
        return Math.Sqrt(dx * dx + dy * dy);
        // return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2));
    }
}


class Program
{
    //1
    /*static void Main(string[] args)
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

    }*/

    private static void Main(string[] args)
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);
        
        double distance = p1.DistanceTo(p2);
        Console.WriteLine($"Distance between points: {distance:F2}");
    }
}