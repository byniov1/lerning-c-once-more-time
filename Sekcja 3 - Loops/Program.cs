using System.Globalization;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i} iteration");
}

//Countdown challenge
Console.WriteLine("Write number you want to countdown from: ");
int countdown = int.Parse(Console.ReadLine());
for (;countdown >= 0; countdown--)
{
    Console.WriteLine($"{countdown}");
}


string myString = "Hi \r\n  hi";
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i} iteration");
}


//while loop
// int counter = 5;
// bool isGood = true;

string userChoice = Console.ReadLine();

while (userChoice == "go")
{
    Console.WriteLine("Life is good");
    Console.WriteLine("Wanna keep going? Enter go");
    userChoice = Console.ReadLine();
 
    
    // counter++;
    // isGood = false;
}

Console.WriteLine("Finnaly your stay");


//do while 

do
{
    Console.WriteLine("Wanna keep going? Enter go");
    userChoice = Console.ReadLine();
}
while(userChoice == "go");


//break and continue
int UPPER = 5;
for (int i = 0; i < UPPER; i++)
{
    if (i == 5)
    {
        Console.WriteLine("I've had enough");
        break;
    }

    if (i == 3)
        continue;
    
    Console.WriteLine($"{i} iteration");    
}




//arrays 

// int[] ints = new int[5]{1,2,3,4,5};
int[] ints = [1,2,3,4,5];



//foreach

foreach (int i in ints)
{
    Console.WriteLine($"Today is {i}");
}





// two dimentional array
int[,] twoDArray = new int[3, 3];
int[,] threeDArray2 = { { 1, 2, 3 }, { 3, 4, 5 } };

































































































