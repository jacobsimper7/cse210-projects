using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        string input = "";
        while (input != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record an event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Please select an option (1-6):");
            input = Console.ReadLine();
            if (input == "1")
            {
                ;
                CreateGoal();
            }
            else if (input == "2")
            {
                ;
                ListGoalDetails();
            }
            else if (input == "3")
            {
                SaveGoals();
            }
            else if (input == "4")
            {
                LoadGoals();
            }
            else if (input == "5")
            {
                RecordEvent();
            }
            else if (input == "6")
            {
                Console.WriteLine("Quitting the program...");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("List of Goals:");
        foreach (Goal goal in _goals)
        {
            int index = _goals.IndexOf(goal) + 1;
            Console.WriteLine($"{index}. {goal.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("List of Goals:");
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                Console.WriteLine($"[✓] {goal.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"[] {goal.GetDetailsString()}");
            }
        }
    }

    public void CreateGoal()
    {
        string choice = "";
        while (choice != "1" && choice != "2" && choice != "3")
        {
            Console.WriteLine("What kind of goal do you want to create?");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("Please select an option (1-3):");
            choice = Console.ReadLine();
        }
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is it worth?");
        int points = int.Parse(Console.ReadLine());
        if (choice == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (choice == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (choice == "3")
        {
            Console.WriteLine("How many times does this goal need to be completed for a bonus?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for completing it that many times?");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record an event.");
            return;
        }
        
        Console.WriteLine("Which goal did you accomplish? (Enter the number)");
        ListGoalNames();
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _score += goal.GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the name of the file you want to save to?(don't add file extention)");
        string fileName = Console.ReadLine();
        if (string.IsNullOrEmpty(fileName))
        {
            fileName = "goals.txt";
        }
        else
        {
            fileName += ".txt";
        }
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to file.");
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file you want to load from? (don't add file extension)");
        string fileName = Console.ReadLine();
        if (string.IsNullOrEmpty(fileName))
        {
            fileName = "goals.txt";
        }
        else
        {
            fileName += ".txt";
        }

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);
        _goals.Clear();
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('-');
            for (int j = 0; j < parts.Length; j++)
                parts[j] = parts[j].Trim();

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                _goals.Add(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                int timesCompleted = parts.Length > 4 ? int.Parse(parts[4]) : 0;
                List<DateTime> completionDates = new List<DateTime>();
                if (parts.Length > 5 && !string.IsNullOrWhiteSpace(parts[5]))
                {
                    completionDates = parts[5].Split(',').Select(s => DateTime.Parse(s)).ToList();
                }
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), timesCompleted);
                _goals.Add(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                _goals.Add(checklistGoal);
            }
        }

        Console.WriteLine("Goals loaded from file.");
    }
}