// See https://aka.ms/new-console-template for more information

namespace Section_17___Linq;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static void OddNumbers(int[] numbers)
    {
        IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number; 
            // numbers.Where(n => n % 2 == 1);
    }

}