using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");
        string choice = Console.ReadLine();
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("You chose to write.");
                // Add code to handle writing a journal entry
            }
            else if (choice == "2")
            {
                Console.WriteLine("You chose to display.");
                // Add code to handle displaying journal entries
            }
            else if (choice == "3")
            {
                Console.WriteLine("You chose to load.");
                // Add code to handle loading journal entries
            }
            else if (choice == "4")
            {
                Console.WriteLine("You chose to save.");
                // Add code to handle saving journal entries
            }
            else if (choice == "5")
            {
                Console.WriteLine("You chose to quit.");
                // Add code to handle quitting the program
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}