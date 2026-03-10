using System.Runtime.InteropServices.JavaScript;
using Microsoft.VisualBasic.CompilerServices;

namespace Section_10___Structs;

//Structs
/*
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

    }#1#

    //2
    /*private static void Main(string[] args)
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);
        
        double distance = p1.DistanceTo(p2);
        Console.WriteLine($"Distance between points: {distance:F2}");
    }#1#
    
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
*/


//Enums
/*
enum Day {Mo, Tu, We, Th, Fr, Sa, Su}
enum Month {January = 1, February, March, April, May, Jun, July = 20, August, September, October, November, December}
class Program
{
    static void Main(string[] args)
    {
        Day fr = Day.Fr;
        Day Su = Day.Su;

        Day a = Day.Fr;

        Console.WriteLine($"Is fr == a {fr == a} this is fr {fr} and this is a {a}");

        Console.WriteLine(Day.Mo);
        Console.WriteLine((int)Day.Mo);
        
        
        Console.WriteLine(Month.February);
        Console.WriteLine((int)Month.February);
        
        Console.WriteLine(Month.August);
        Console.WriteLine((int)Month.August);
    }
}
*/


//DateTime
/*
class Program
{
    static void Main(string[] args)
    {
        DateTime date = new DateTime(1988, 5, 31);
        Console.WriteLine($"My birthday is {date}");

        //Write today on screnn
        Console.WriteLine($"Today is {DateTime.Today}");

        //Write current time on screen
        Console.WriteLine($"Today is {DateTime.Now}");

        //Write tomorrow date
        Console.WriteLine($"Tomorrow is {DateTime.Today.AddDays(1)}");

        Console.WriteLine($"Today is {DateTime.Today.DayOfWeek}");

        Console.WriteLine($"First day of the year 2020 was {GetFirstDayOfYear(2020)} and it was {GetFirstDayOfYear2(2020)}");
     
        
        int days = DateTime.DaysInMonth(2000, 2);
        Console.WriteLine($"Days in Frb 2000 was {days}");

        DateTime now = DateTime.Now;
        Console.WriteLine($"Now Minute is {now.Minute}");
        
        
        DateTime now2 = DateTime.Now;
        Console.WriteLine("Write a date in this format: yyyy-mm-dd");
        string input = Console.ReadLine();
        if (DateTime.TryParse(input, out DateTime dateTime))
        {
            Console.WriteLine(dateTime);
            TimeSpan daysPassed = now.Subtract(dateTime); //dateTime.Subtract(now);
            Console.WriteLine($"Time passed since {daysPassed.Days} ");
        }
        
    }


    static DateTime GetTommorow()
    {
        return DateTime.Today.AddDays(1);
    }

    static DateTime GetFirstDayOfYear(int year)
    {
        return new DateTime(year, 1, 1);
    }

    static DayOfWeek GetFirstDayOfYear2(int year)
    {
        return new DateTime(year, 1, 1).DayOfWeek;
    }

}
*/

//MathClass
/*
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Ceiling " + Math.Ceiling(15.3));

        int num1 = 13;
        int num2 = 5;
        Console.WriteLine($"the lower of {num1} and {num2} is {Math.Min(num1, num2)}");
        Console.WriteLine($"3 to the power of 5 is {Math.Pow(3, 5)}");
        Console.WriteLine($"Always positive is {Math.Abs(-20)}");
        Console.WriteLine($"cos of 1 is {Math.Cos(1)}");
    }
}
*/

//Garbage collection
class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}


































