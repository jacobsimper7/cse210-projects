public class Entry
{
    public string _promptText;
    public string _entryText;
    public DateTime _date;
    public Entry(string prompt, string response)
    {
        _promptText = prompt;
        _entryText = response;
        _date = DateTime.Now;
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
    }
}