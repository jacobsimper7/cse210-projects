using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumberInput = Console.ReadLine();
        // int number = int.Parse(magicNumberInput);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int guess = 0;
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess < number)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("Too high!");
            }
        }
    }
}