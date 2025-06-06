class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you made a difference in someone's life.",
        "Think of a time when you learned something new about yourself.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you felt the spirit strongly.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description, int duration = 0)
        : base(name, description, duration)
    {
        // Constructor for ReflectingActivity, initializes the base class with name, description, and duration
    }

    public void Run()
    {
        string input = "continue";
        while (input != "")
        {
            Console.WriteLine("Consider the following prompt:");
            DisplayPrompt();
            Console.WriteLine("When you have something in mind, press enter to continue or type 'new' if you want a new prompt)");
            input = Console.ReadLine();
            if (input == "new")
            {
                Console.Clear();
            }
            else if (input == "")
            {
                break;
            }
            else
                Console.WriteLine("Invalid response, try again.");           
            
        }

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountdown(6);
        Console.Clear();
        DisplayQuestions();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--{prompt}--");
    }

    private void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(7);
        }
    }
}