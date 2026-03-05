using System.Collections;

namespace Section_6___Collection;

class Program
{
    //1
    /*static void Main(string[] args)
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
        
        
        DisplayList(colors);

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
        DisplayList(colors);
    }*/

    //2
    /*static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 5, 15, 2, 3, 9, 2, 0, 2, 2 };
        DisplayList(numbers, "Numbers");
        
        numbers.Sort();
        DisplayList(numbers, "Sorted numbers");
    
        List<int>higherEqualTen = numbers.FindAll(element => element >= 10);
        DisplayList(higherEqualTen, "Numbers, greater than 10");
        
        
        // Predicate<int> isGreaterThanTen = number => number > 10;
        Predicate<int> isGreaterThanTen = IsGreaterThanTen;
        List<int>higherTen = numbers.FindAll(isGreaterThanTen);
        DisplayList(higherTen, "Numbers, greater than 10");
    
        bool isThereNumberGreaterThat20 = numbers.Any(number => number > 20);
        Console.WriteLine("isThereNumberGreaterThat20: " + isThereNumberGreaterThat20);
    }*/

    //3
    /*public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
    }
    
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product { Name = "Pepperoni", Price = 9.99 },
            new Product { Name = "Apple", Price = 5.99 },
            new Product { Name = "Banas", Price = 0.30 }
        };
        products.Add(new Product { Name = "Apple", Price = 9.99 });

        
        foreach (Product product in products)
        {
            Console.WriteLine($"Product: {product.Name} - {product.Price}");
        }
        
        
        //Linq
        List<Product> cheapProducts = products.Where(product => product.Price < 1.0).ToList();
        Console.WriteLine("\nCheap Products:");
        foreach (Product product in cheapProducts)
        {
            Console.WriteLine($"Product: {product.Name} - {product.Price}");
        }
    }

    private static void DisplayList<T>(List<T> list, string textToDisplay)
    {
        Console.WriteLine(textToDisplay);
        foreach (var element in list)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }
    
    private static bool IsGivenColor(string color,  string givenColor)
    {
        return color == givenColor;
    }

    private static bool IsGreaterThanTen(int number)
    {
        return number > 10;
    }*/

    public static void Main(string[] args)
    {
        ArrayList myArrayList = new ArrayList();
        ArrayList myArrayList2 = new ArrayList(100);
        
        myArrayList.Add("Hello World");
        myArrayList.Add(2);
        myArrayList.Add(2);
        myArrayList.Add(false);
        myArrayList.Add(21.37);
        myArrayList.Add(21.37);
        myArrayList.Add(128);
        myArrayList.Add(128);
        
        //Remove specyfic value from arrayList
        myArrayList2.Remove(2);
        
        //delete element at specyfic position
        myArrayList.RemoveAt(4);

        Console.WriteLine("Elements in myArrayList" + myArrayList.Count);


        double sum = 0;
        foreach (var item in myArrayList)
        {
            if (item is int)
            {
                sum += Convert.ToDouble(item);
            }
            else if (item is double)
            {
                sum += (double)(item);
            }
            else
            {
                Console.WriteLine(item);
            }
        }

        Console.WriteLine($"Sum of number: {sum}");
        
    }
}