namespace Section_10___Structs;

public struct Point
{
    //Jest częstą praktyką że structs robi się immutable by declaring all fields as readonly and providing only get accessors for props
    public int X { get; set; }
    public int Y { get; set; }
    // public int X;
    // public int Y;
    // public double X { get;  }
    // public double Y { get; }
    
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

public class PointClass
{
    public double X { get; set; }
    public double Y { get; set;}
    
    public PointClass(int x, int y)
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

    //2
    /*private static void Main(string[] args)
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);
        
        double distance = p1.DistanceTo(p2);
        Console.WriteLine($"Distance between points: {distance:F2}");
    }*/
    
    private static void Main(string[] args)
    {
        Point p1 = new Point(1, 2);
        p1.Display();
        
        Point p2 = p1;
        p2.Display();
        p2.X = 25;
        Console.WriteLine("After changing p2.X to 25");
        p1.Display();
        p2.Display();
        Console.WriteLine($"Is p1 == p2 {p1.Equals(p2)}");
        bool isEqual = Equals(p1, p2);
        Console.WriteLine($"Is p1 == p2 {isEqual}  ----- Different method");

        Console.WriteLine("\nNow come the class object");
        PointClass pC1 = new PointClass(1, 2);
        PointClass pC2 = pC1;
        pC1.Display();
        pC2.Display();
        Console.WriteLine($"iS pC1 == pC2 {pC1.Equals(pC2)}");

        pC2.X = 3;
        Console.WriteLine("After changing pC2.X to 3");
        pC1.Display();
        pC2.Display();
        
        
        
        double distance = p1.DistanceTo(p2);
        Console.WriteLine($"Distance between points: {distance:F2}");
    }
}












































