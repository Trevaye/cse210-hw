using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals; // List to store all goals
    private int _score; // Variable to store the player's score

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Main loop to display menu and process user input
    public void Start()
    {
        while (true)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Display the player's current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    // List the names of all goals
    public void ListGoalNames()
    {
        Console.WriteLine("Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    // List detailed information about all goals
    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    // Create a new goal based on user input
    public void CreateGoal()
    {
        Console.WriteLine("Create a new goal:");
        Console.Write("Enter goal type (simple, eternal, checklist): ");
        string type = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal = null;

        // Create the appropriate type of goal based on user input
        switch (type.ToLower())
        {
            case "simple":
                goal = new SimpleGoal(name, description, points);
                break;
            case "eternal":
                goal = new EternalGoal(name, description, points);
                break;
            case "checklist":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not created.");
                return;
        }

        _goals.Add(goal);
        Console.WriteLine("Goal created successfully.");
    }

    // Record an event for a selected goal
    public void RecordEvent()
    {
        Console.WriteLine("Record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.Write("Choose a goal to record: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        Goal selectedGoal = _goals[choice - 1];
        selectedGoal.RecordEvent();
        _score += selectedGoal.GetPoints();

        // If it's a checklist goal and it is complete, add bonus points
        if (selectedGoal.IsComplete() && selectedGoal is ChecklistGoal checklistGoal)
        {
            _score += checklistGoal.GetBonus();
        }

        Console.WriteLine("Event recorded successfully.");
    }

    // Save the goals and score to a file
    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    // Load the goals and score from a file
    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            _score = int.Parse(reader.ReadLine());
            _goals.Clear();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split('|');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = null;

                // Recreate the appropriate type of goal based on the saved data
                switch (type)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(parts[4]);
                        goal = new SimpleGoal(name, description, points, isComplete);
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(name, description, points);
                        break;
                    case "ChecklistGoal":
                        int amountCompleted = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                        break;
                }

                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}