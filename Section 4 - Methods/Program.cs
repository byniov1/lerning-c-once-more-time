namespace Section_4___Methods;

// class Program
// {
//     //Fields or instance variable
//     public int myResult;
//     
//     static void Main(string[] args)
//     {
//         Program program = new Program();
//         program.MyFirstMethod("Something passed to a method");
//         // MyFirstMethod();
//         program.myResult++;
//
//         // void MyFirstMethod()
//         // {
//         //     throw new NotImplementedException();
//         // }
//     }
//     
//     // static void MyFirstMethod(string firstParameter)
//     void MyFirstMethod(string firstParameter)
//     {
//         Console.WriteLine($"My first void method that prints {firstParameter}");
//     }
//
// }

//WeatherStationSimulator
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of days to simulate");
        int days = int.Parse(Console.ReadLine());

        int[] temperature = new int[days];
        string[] conditions = { "Suuny", "Rainy", "Cloudy", "Snowy" };
        string[] weatherConditions = new string[days];
        
        Random rnd = new Random();

        for (int i = 0; i < days; i++)
        {
            temperature[i] = rnd.Next(-10, 40);
            weatherConditions[i] = conditions[rnd.Next(conditions.Length)];
        }

        double averageTemperature = CalculateAverageTemperature(temperature);
        Console.WriteLine($"Average temperature: {averageTemperature}");

        
        // temperature.Min();
        // temperature.Max();
        Console.WriteLine($"Min temperature was: {temperature.Min()} \n Max temperature was: {temperature.Max()} ");
        Console.WriteLine($"Min temperature was: {MinTemperature(temperature)}");

        Console.WriteLine($"Most common condition is {MostCommonCodition(weatherConditions)}");
        
    }

    private static double CalculateAverageTemperature(int[] temperature)
    {
        // double sum = 0;
        // foreach (var temper in temperature)
        // {
        //     sum += temper;
        // }
        //Code after implementing suggestion
        var sum = temperature.Aggregate<int, double>(0, (current, temper) => current + temper);
        
        var average = sum / temperature.Length;
        return average;
    }

    static int MinTemperature(int[] temperature)
    {
        int min = temperature[0];

        foreach (var temper in temperature)
        {
            if(temper < min)
            {
                min = temper;
            }
        }
        
        return min;
    }

    static string MostCommonCodition(string[] conditions)
    {
        int count = 0;
        string mostCommon = conditions[0];

        for (int i = 0; i < conditions.Length; i++)
        {
            int tempCount = 0;
            for (int j = 0; j < conditions.Length; j++)
            {
                if (conditions[i] == conditions[j])
                    tempCount++;
            }

            if (tempCount > count)
            {
                count = tempCount;
                mostCommon = conditions[i];
            }
            
        }

        return mostCommon;
    }
}
