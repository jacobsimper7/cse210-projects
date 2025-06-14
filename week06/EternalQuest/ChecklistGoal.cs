using System.IO;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"You have completed {_amountCompleted} out of {_target} for this goal.");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You have completed the goal and earned a bonus of {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"You have completed the goal and earned a bonus of {_bonus} points!");
            return true;
        }
        else
        {
            Console.WriteLine($"You have completed {_amountCompleted} out of {_target} for this goal.");
            return false;
        }

    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description}) (Points: {_points}) - Completed: {_amountCompleted}/{_target}, Bonus: {_bonus})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal - {_shortName} - {_description} - {_points} - {_amountCompleted}/{_target} - {_bonus}";
    }
}