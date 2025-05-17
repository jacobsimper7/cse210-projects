public class Entry
{
    public string _promptText;
    public string _entryText;
    public DateTime _date;
    public string _daysOfSobriety;
    public string _dailyGoals;
    public Entry(string prompt, string response, string sobriety, string dailyGoals)
    {
        _promptText = prompt;
        _entryText = response;
        _date = DateTime.Now;
        _daysOfSobriety = sobriety;
        _dailyGoals = dailyGoals;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine($"Days of Sobriety: {_daysOfSobriety}");
        Console.WriteLine($"Days in a row completed Daily Goals: {_dailyGoals}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }
}