using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Press enter to start...");
        Console.ReadLine();

        // Create a new scripture object
        Reference reference = new Reference("John", 3, 16);
        string verseText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, verseText);

        // Display the scripture text
        while (!scripture.IsCompletelyHidden())
        {
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Press Enter to quit.");
                Console.ReadLine();
                break;
            }
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            // Hide a random number of words
            // You can change the number of words to hide here
            scripture.HideRandomWords(2);

        }
        Console.WriteLine("All words are hidden or you chose to quit.");
    }
}