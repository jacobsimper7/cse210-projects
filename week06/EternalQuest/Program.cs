using System.IO;
// I exceeded the requierments by adding things to the eternal goal so that you can see how many times and when you completeed the goal
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