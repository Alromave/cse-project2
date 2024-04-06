// Manager class
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
        int choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new Goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Player Info");
            Console.WriteLine("7. Quit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    DisplayPlayerInfo();
                    break;
                case 7:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 7);
    }

    public void CreateGoal()
    {
        Console.WriteLine("Creating new Goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        int type = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the name of your goal?: ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of the points associated with this goal?: ");
        int points = Convert.ToInt32(Console.ReadLine());
        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(shortName, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(shortName, description, points));
                break;
            case 3:
                Console.Write("Enter target: ");
                int target = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter bonus: ");
                int bonus = Convert.ToInt32(Console.ReadLine());
                _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("List of Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter file name to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter file name to load: ");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split(",");
                string shortName = parts[0];
                string description = parts[1];
                int points = Convert.ToInt32(parts[2]);
                int amountCompleted = Convert.ToInt32(parts[3]);
                int target = Convert.ToInt32(parts[4]);
                int bonus = Convert.ToInt32(parts[5]);
                if (target == 0) // Simple or Eternal Goal
                {
                    if (amountCompleted == 0)
                        _goals.Add(new SimpleGoal(shortName, description, points));
                    else
                        _goals.Add(new EternalGoal(shortName, description, points));
                }
                else 
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                    checklistGoal.RecordEvent(); 
                    _goals.Add(checklistGoal);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select the goal to record event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice >= 1 && choice <= _goals.Count)
        {
            _goals[choice - 1].RecordEvent();
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's Score: {_score}");
    }
}