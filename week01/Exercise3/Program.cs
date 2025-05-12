using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumberInput = Console.ReadLine();
        // int number = int.Parse(magicNumberInput);

        
        bool game = true;
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I have selected a number between 1 and 10. Can you guess it?");

        while (game)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
            int guess = 0;
            int numberOfGuesses = 0;
            Console.Write("Would you like to play the game? (yes/no) ");
            string playInput = Console.ReadLine();
            string play = playInput.ToLower();
            if (play == "no")
            {
                game = false;
                Console.WriteLine("Thanks for playing!");
                break;
            }
            else if (play != "yes")
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                continue;
            }
            while (guess != number)
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
            guess = int.Parse(guessInput);
            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"You guessed {numberOfGuesses} times.");
            }
            else if (guess < number)
            {
                numberOfGuesses++;
                Console.WriteLine($"You have guessed {numberOfGuesses} times.");
                Console.WriteLine("Too low!");
            }
            else
            {
                numberOfGuesses++; 
                Console.WriteLine($"You have guessed {numberOfGuesses} times.");
                Console.WriteLine("Too high!");
            }
        }
        }        
    }
}