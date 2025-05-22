using System;

// The creativity I added to this program is the options to enter their own scripture to memorize, 
// take mini-quiz at the end, and keep taking the quiz until they get it right.
// After the user has hidden all the words in the scripture, they are prompted to recall the verse.
// If they enter the correct verse, they are congratulated. If they enter an incorrect verse,
// they are shown the correct verse and a comparison of their input with the correct verse.
// This is done with the DisplayComparison method in the Scripture class.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("What is the reference of the scripture you like to memorize?");
        Console.WriteLine("You can use the format: Book Chapter:Verse(s)");
        Console.WriteLine("For example: John 3:16 or John 3:16-18");
        string inputReference = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(inputReference))
        {
            Console.WriteLine("Invalid reference. Please try again.");
            return;
        }
        Console.WriteLine("What is the text of the scripture you like to memorize?");
        string inputText = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(inputText))
        {
            Console.WriteLine("Invalid text. Please try again.");
            return;
        }
        Console.WriteLine("Great! Let's get started.");
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();

        // Create a new scripture object
        // Assuming the input reference is in the format "Book Chapter:Verse(s)"
        string[] referenceParts = inputReference.Split(' ');
        string book = referenceParts[0];
        int chapter = int.Parse(referenceParts[1].Split(':')[0]);
        string versePart = referenceParts[1].Split(':')[1];
        int verseStart = int.Parse(versePart.Split('-')[0]);
        int verseEnd = verseStart; // Default to the same verse if no range is provided
        if (versePart.Contains('-'))
        {
            verseEnd = int.Parse(versePart.Split('-')[1]);
        }

        Reference reference = new Reference(book, chapter, verseStart, verseEnd);
        // string verseText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, inputText);

        // Display the scripture text
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            // Hide a random number of words
            // You can change the number of words to hide here
            scripture.HideRandomWords(1);

            // This was to reduce the number of times the screen clears
            // if (inputText.Length > 20)
            //     scripture.HideRandomWords(3);
            // else
            //     scripture.HideRandomWords(1);

            if (scripture.IsCompletelyHidden())
            {
                break;

            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Congratulations! You've hidden all the words.");
        Console.WriteLine("Would you like to quiz yourself now?");
        Console.WriteLine("Press enter to continue...");
        Console.WriteLine("Or type 'quit' to exit.");
        string takeQuiz = Console.ReadLine();
        if (takeQuiz.ToLower() == "quit")
            return;

        while (true)
        {
            Console.WriteLine("QUIZ TIME!");
            Console.WriteLine("Try to recall the scripture, type it exactly");
            Console.WriteLine("Press enter to check your answer or type 'quit' to exit.");
            string quizInput = Console.ReadLine();
            if (quizInput.ToLower() == "quit")
                break;
            else if (quizInput.ToLower() == inputText.ToLower())
            {
                Console.WriteLine("Correct! Well done.");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect. Let's see how well you did.");
                scripture.DisplayComparison(quizInput, inputText);
                Console.WriteLine("The correct verse is:");
                Console.WriteLine(inputText);
                Console.WriteLine("Press enter to try again or type 'quit' to exit.");
                string tryAgain = Console.ReadLine();
                if (tryAgain.ToLower() == "quit")
                    break;
                else
                    Console.Clear();
                Console.WriteLine("Let's try again!");
                continue;
            }

        }
        Console.WriteLine("Thank you for using the Scripture Memorizer!");
        Console.WriteLine("Goodbye!");
    }
}