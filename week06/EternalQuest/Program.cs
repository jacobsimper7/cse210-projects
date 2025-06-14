using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest program!");
        Console.WriteLine("This program helps you track your goals and achievements.");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}