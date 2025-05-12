using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 wehen finished.");
        List<int> numbers = new List<int>();
        int number = 1;
        int sum = 0;
        int greatest = 0;
        int smallest = 100;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            // Check if the number is not zero before adding it to the list
            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
            }
            // Check if the number is greater than the current greatest number
            // and if it is not zero
            if (number < smallest && number != 0)
            {
                smallest = number;
            }
            else if (number > greatest)
            {
                greatest = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is {sum / numbers.Count}.");
        Console.WriteLine($"The greatest number is {greatest}.");
        Console.WriteLine($"The smallest number is {smallest}.");
    }
}