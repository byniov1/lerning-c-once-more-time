namespace Section_5___OOP;

public class Quiz
{
    private Question[] questions;

    public Quiz(Question[] questions)
    {
        this.questions = questions;
    }

    public void DisplayQuestion(Question question)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                 Question                                ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine(question.QuestionText);


        for (int i = 0; i < question.Anwsers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("    ");
            Console.Write(i+1);
            Console.ResetColor();
            Console.WriteLine($". {question.Anwsers[i]}");
        }

        if (GetUserChoice() == question.CorrectAnwserIndex)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect");
        }
    }

    private int GetUserChoice()
    {
        Console.Write("Your anwser (number): ");
        string input = Console.ReadLine();
        int choice = 0;
        while(!int.TryParse(input, out choice) || choice < 1 || choice > 4 )
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4");
            input = Console.ReadLine();
        }

        return choice-1;
    }
}