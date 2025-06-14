using System.IO;

public class EternalGoal : Goal
{
    private int _timesCompleted = 0;

    public EternalGoal(string name, string description, int points, int timesCompleted = 0)
        : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        Console.WriteLine($"You have completed this goal {_timesCompleted} times.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description}) (Points: {_points}) - Completed: {_timesCompleted} times";
    }

    public override string GetStringRepresentation()
    {
        // Save dates as comma-separated yyyy-MM-dd
        return $"EternalGoal - {_shortName} - {_description} - {_points} - {_timesCompleted}";
    }
}