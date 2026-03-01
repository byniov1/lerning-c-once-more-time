// bool isRainy = false;
// bool hasUmbrella = true;
//
// if (!isRainy ||  hasUmbrella)
// {
//     Console.WriteLine("I'm not getting weat!");
// }
//
// Console.WriteLine("Ay OK!");

//relationala operators
// int num1 = 5;
// int num2 = 60;
// bool isHigher = num1 > num2;
//
// int age = 35;
//
// if (age >= 18)
// {
//     Console.WriteLine("You can go party");
// }
// else if (age > 6)
// {
//     Console.WriteLine("Go to shool");
// }
// else
// {
//     Console.WriteLine("Go to kindergarden");
// }

int month = 5;
string monthName;

if (month == 1)
{
    monthName = "January";
}
else if (month == 2)
    monthName = "February";
else if (month == 3)
    monthName = "March";
else
    monthName = "Unknown";


switch (month)
{
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    default:
        monthName = "Unknown";
        break;
}



string anwser = Console.ReadLine();
Console.WriteLine(anwser.Trim().ToLower());