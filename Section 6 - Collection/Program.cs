namespace Section_6___Collection;

class Program
{
    static void Main(string[] args)
    {
        List<string> colors = new List<string>();
        colors.Add("Red");
        colors.Add("Blue");
        colors.Add("Yellow");

        foreach (string color in colors)
        {
            Console.WriteLine($"Color: {color}");
        }
    }
}