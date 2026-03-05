namespace Section_6___Collection;

class Program
{
    static void Main(string[] args)
    {
        // List<string> colors = new List<string>();
        // colors.Add("Red");
        // colors.Add("Blue");
        // colors.Add("Yellow");
        // colors.Add("Yellow");
        // colors.Add("Yellow");
        
        List<string> colors =
        [
            "Red",
            "Blue",
            "Yellow",
            "Yellow",
            "Yellow"
        ];
        
        
        DisplayColors(colors);

        Console.WriteLine("\nI'm removing items");
        // colors.Remove("Yellow");
        // bool isDeletingSuccessfull = colors.Remove("Yellow");
        
        //delete all yellow
        //1
        // while (isDeletingSuccessfull)
        // {
        //     isDeletingSuccessfull = colors.Remove("Yellow");
        // }
        
        //2
        //Można to było uprościć ale bajka nie wiedzialem jak dorwać się do "color"
        colors.RemoveAll(color => IsGivenColor(color, "Yellow"));
        // var filteredColors = colors.Where(c => c != "Yellow").ToList();                                      !!!! HINT NA PRZYSZŁOŚĆ !!!! 
        DisplayColors(colors);
    }

    private static void DisplayColors(List<string> colors)
    {
        foreach (string color in colors)
        {
            Console.WriteLine($"Color: {color}");
        }
    }
    
    private static bool IsGivenColor(string color,  string givenColor)
    {
        return color == givenColor;
    }
}