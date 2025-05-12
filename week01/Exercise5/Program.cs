using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, userNumber, squaredNumber);
    }
    static string DisplayWelcome()
    {
        return "Welcome to the Program!";
    }
    static string PromptUserName()
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        return $"{lastName}, {firstName} {lastName}";
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string inputNumber = Console.ReadLine();
        int number = int.Parse(inputNumber);
        return number;
    }
    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
        
    }
    static void DisplayResult(string name, int number, int squaredNumber)
    {
        Console.WriteLine($"Hello {name}, your favorite number is {number} and its square is {squaredNumber}.");
    }
}