using System.Diagnostics;

namespace Section_7___ErrorHandling;

class Program
{
    //1
    /*static void Main(string[] args)
    {
        
        /*Console.WriteLine("Hello, World!");

        int result = 0;
        Debug.WriteLine("Main method is running");
        try
        {
            int num1 = 0;
            int num2 = 2;
            result = num2 / num1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            Console.WriteLine(e.Message);
            
            Debug.WriteLine(e.StackTrace);
            Debug.WriteLine(e.ToString());
        }
        finally
        {
            Console.WriteLine($"Result {result}");
            Console.WriteLine("This always executes");
            Console.WriteLine("Goodbye");
        }#1#
    }*/
    
    //2
    /*static void Main(string[] args)
    {
        GetUserAge("125");
    }
    
    private static int GetUserAge(string input)
    {
        int age;
        if (!int.TryParse(input,out age))
        {
            throw new  Exception("You didn't enter a valid age");
        }

        if (age < 0 || age > 123)
        {
            throw new Exception("Your age must be between 0 and 120");
        }

        Console.WriteLine($"Your age is {age}");
        return age;
    }*/
    
    static void Main(string[] args)
    {

        int result = 0;
    Debug.WriteLine("Main method is running");
    try
    {
        int num1 = 0;
        int num2 = 2;
        result = num2 / num1;
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Don't divide by zero: " + ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine("You must provide number: " + ex.Message);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Number to high: "  + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("This always executes");
    }
    }
}