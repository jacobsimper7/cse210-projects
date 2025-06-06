class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration = 0)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.WriteLine($"How long would you like to do this activity? (in seconds)");
        if (_duration == 0)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int duration))
            {
                _duration = duration;
            }
            else
            {
                Console.WriteLine("Invalid input. Defaulting to 30 seconds.");
                _duration = 30;
            }
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(5);
        Console.WriteLine($"Thank you for participating in the {_name}!");
        Console.WriteLine($"You participated in this activity for {_duration} seconds.");
        ShowSpinner(5);
        Console.Clear();
    }
    public void ShowSpinner(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        string[] spinner = { "|", "/", "-", "\\" };
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250); // Wait for 250 milliseconds
            Console.Write("\b \b"); // Erase the spinner character

            i++;
            if (i >= spinner.Length)
            {
                i = 0; // Reset the index to loop through the spinner
            }
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Wait for 1 second
            if (seconds > 9)
                Console.Write("\r  \r"); // Overwrite the number for a cleaner look
            else if (seconds < 10)
                Console.Write("\r \r");
        }
    }
}