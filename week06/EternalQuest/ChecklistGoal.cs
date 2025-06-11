public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private bool _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
       
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true; // Placeholder logic, should be replaced with actual completion logic
    }

    public string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}