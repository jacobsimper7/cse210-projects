// To exceed the core requirements, I added a feater for recovering addicts to record their days of sobriety as well 
// as how they did with their dayly goals

using System;
using System.ComponentModel;
using System.IO;

class Program
{
    // This program is a simple journal application that allows the user to write journal entries,
    // display them, and save/load them to/from a file.
    static Journal journal = new Journal();
    static void Main(string[] args)
    {

        string choice = "";
        // Loops through the menu until the user chooses to quit
        // The menu is displayed again after each choice
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            // Gets the user's choice and is stored in the variable 'choice'
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Write();
            }
            else if (choice == "2")
            {
                Display();
            }
            else if (choice == "3")
            {
                Load();
                Console.WriteLine("Entries loaded successfully.");
            }
            else if (choice == "4")
            {
                Save();
                Console.WriteLine("Entries saved successfully.");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Have a nice day!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
    static void Write()
    {
        // This method is called when the user chooses to write a journal entry
        // It generates a random prompt and gets the user's response
        // Gets the user's days of sobriety and their daily goals
        Console.WriteLine("How many days of sobriety do you have?");
        string sobriety = Console.ReadLine();
        Console.WriteLine("How many days in a row have you met your daily goals?");
        string dailyGoals = Console.ReadLine();

        PromptGenerator prompt = new PromptGenerator();
        string promptText = prompt.GetRandomPrompt();
        Console.WriteLine(promptText);

        // Gets the user's response
        string response = Console.ReadLine();

        // Stows the response in an Entry object
        Entry entry = new Entry(promptText, response, sobriety, dailyGoals);
        // The entry is formatted as a string with the date, prompt, and response
        string entryText = entry._date.ToShortDateString() + "\n" + "#Days of sobriety: " + entry._daysOfSobriety + "\n" +
        "Days in a row completed daily goals: " + entry._dailyGoals + "\n" + entry._promptText + "\n" + entry._entryText + "\n|";

        // Adds the entry to the journal
        journal.AddEntry(entryText);
    }
    static void Display()
    {
        // This method is called when the user chooses to display their journal entries
        journal.DisplayEntries();
    }
    static void Load()
    {
        // This method is called when the user chooses to load their journal entries
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();
        // Reads all lines from the file
        string[] lines = System.IO.File.ReadAllLines(fileName);
        // Loops through each line in the file and adds it to the journal
        foreach (string line in lines)
        {
            journal.AddEntry(line);
        }

    }
    static void Save()
    {
        // This method is called when the user chooses to save their journal entries
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();
        // Opens the file for writing
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // Loops through each entry in the journal
            // Writes each entry to the file
            foreach (string entry in journal._entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}