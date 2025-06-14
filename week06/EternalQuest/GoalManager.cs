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
                Console.WriteLine("Creating a new goal...");
                CreateGoal();
            }
            else if (input == "2")
            {
                Console.WriteLine("Listing goals...");
                ListGoalDetails();
            }
            else if (input == "3")
            {
                SaveGoals();
            }
            else if (input == "4")
            {
                Console.WriteLine("Loading goals...");
                // Call the method to load goals
            }
            else if (input == "5")
            {
                Console.WriteLine("Recording an event...");
                // Call the method to record an event
            }
            else if (input == "6")
            {
                Console.WriteLine("Quitting the program...");
                // Exit the program
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
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("List of Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
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

    }
}