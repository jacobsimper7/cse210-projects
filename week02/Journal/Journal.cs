public class Journal
{
    public List<string> _entries = new List<string>();
    public void AddEntry(string entry)
    {
        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
}