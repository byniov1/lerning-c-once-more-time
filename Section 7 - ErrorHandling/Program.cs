namespace Section_7___ErrorHandling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        try
        {
            int num1 = 0;
            int num2 = 2;
            int result = num2 / num1;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
            throw;
        }
            Console.WriteLine($"");
        
        Console.WriteLine(result);
    }
}