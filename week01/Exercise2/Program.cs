using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        int lastDigit = grade % 10;
        string gradeSign = "";
        // Determine the grade sign based on the last digit
        if (lastDigit >= 7)
        {
            gradeSign = "+";
        }
        else if (lastDigit <= 3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }

        if (grade >= 90)
        {
            Console.WriteLine($"You got an A!");
        }
        else if (grade >= 80)
        {
            Console.WriteLine($"You got a {gradeSign}B!");
        }
        else if (grade >= 70)
        {
            Console.WriteLine($"You got a {gradeSign}C!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine($"You got a {gradeSign}D!");
        }
        else
        {
            Console.WriteLine($"You got an F.");
        }
    }
}