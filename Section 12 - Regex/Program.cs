using System.Text.RegularExpressions;

namespace Section_12___Regex;

// https://learn.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\d";
        Regex regex = new Regex(pattern);

        string text = "Hi there, my number is 12314";
        
        MatchCollection matchCollection = regex.Matches(text);
        
        Console.WriteLine($"{matchCollection.Count} hits found in test: {text} \n");
        foreach (Match match in matchCollection)
        {
            GroupCollection groupCollection = match.Groups;
            Console.WriteLine($"{groupCollection[0].Value} found at {groupCollection[0].Index} index");
        }
    }
}