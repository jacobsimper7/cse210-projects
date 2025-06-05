using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Assignment
        Assignment assignment = new Assignment("John Doe", "Math Homework");

        // Display the summary of the assignment
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Jane Smith", "Algebra", "Section 5.2", "Problems 1-10");
        // Display the summary of the math assignment
        Console.WriteLine(mathAssignment.GetSummary());
        // Display the homework list for the math assignment
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Alice Johnson", "History Essay", "The Renaissance");
        // Display the summary of the writing assignment
        Console.WriteLine(writingAssignment.GetSummary());
        // Display the writing information for the writing assignment
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}