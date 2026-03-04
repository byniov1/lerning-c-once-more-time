using System.Security.AccessControl;

namespace Section_5___OOP;

class Program
{
    static void Main(string[] args)
    {
        //1
        /*Car audi = new Car("Audi", "A5", false);
        Car bmw = new Car("BMW", "i7", true);

        Console.WriteLine("Please enter the brand name");
        audi.Brand = Console.ReadLine();

        Console.WriteLine("Brand is: " + audi.Brand);*/
        
        //2
        /*Customer defaultCustomer = new Customer();
        Customer customer = new Customer("John Doe");*/
        
        //3
        /*Car audi = new Car("Audi", "A4", false);
        audi.Drive();
        
        Customer defaultCustomer = new  Customer();
        defaultCustomer.PrintDetails();
        Console.WriteLine("I'm now setting info about customer");
        // defaultCustomer.SetDetails("John Doe", "John Doe", "Some address");
        defaultCustomer.SetDetails("John Doe", "John Doe");
        defaultCustomer.PrintDetails();*/
        
        //4 Named Parameters
        /*
        static int AddNum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
          
        Console.WriteLine(AddNum(15, 25));
        Console.WriteLine(AddNum(firstNum: 25, 25));*/
        
        //5
        /*Customer.DoSomethingCustomerStuff();*/
        
        //6
        /*Customer customer1 = new Customer();
        Customer customer2 = new Customer();
        Customer customer3 = new Customer();
        Customer customer4 = new Customer();
        customer4.GetDetalis();

        customer4.Password = "dfkjhsajkh8234yu91$";
        customer4.GetDetalis();*/

        
        //7
        /*Rectangle rectangle1 = new Rectangle("Red");
        Rectangle rectangle2 = new Rectangle("Blue");

        rectangle2.DisplayDetails();*/
        
        //8
        //Quiz
        Question[] questions = new Question[]
        {
            new Question(
                "What is the capital of Germany?",  // Question Text
                new string[] {"Paris", "Berlin", "London", "Madrid"}, // Answers Array
                1 // CorrectAnswerIndex
            ),
            new Question(
                "What is 2+2?",  // Question Text
                new string[] {"3", "4", "5", "6"}, // Answers Array
                1 // CorrectAnswerIndex
            ),
            new Question(
                "Who wrote 'Hamblet'?",  // Question Text
                new string[] {"Goethe", "Austen", "Shakespeare", "Dickens"}, // Answers Array
                2 // CorrectAnswerIndex
            )
        };

        Quiz quiz = new Quiz(questions);
        quiz.StartQuiz();
        // quiz.DisplayQuestion(questions[0]);
    }


}