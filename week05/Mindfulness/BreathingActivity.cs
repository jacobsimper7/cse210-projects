class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, int duration = 0)
        : base(name, description)
    {
        _duration = duration;
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Hold...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
            Console.WriteLine("Hold...");
            ShowCountdown(4);
        }
    }
}