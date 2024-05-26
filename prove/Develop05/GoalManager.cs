using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    // Start the goal manager
    public void Start()
    {
        LoadGoals();  // Load saved goals and score
        bool running = true;
        while (running)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save and Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    SaveGoals();
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }

    // Display player's score and goal count
    private void DisplayPlayerInfo()
    {
        Console.WriteLine("=== Eternal Quest ===");
        Console.WriteLine($"Total Score: {_score}");
        Console.WriteLine($"Number of Goals: {_goals.Count}");
        Console.WriteLine("=====================");
    }

    // List names of all goals
    private void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i]._shortName}");
        }
    }

    // List details of all goals
    private void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    // Create a new goal based on user input
    private void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Create New Goal");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose a goal type: ");

        string typeChoice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter the target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the checklist: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice, try again.");
                break;
        }
    }

    // Record an event for a selected goal
    private void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Record Event");
        ListGoalNames();

        Console.Write("Enter the goal number to record: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            _goals[goalIndex].RecordEvent();
            _score += _goals[goalIndex]._points;
            if (_goals[goalIndex] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.BonusPoints;
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }

        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }

    // Save goals and score to a file
    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Progress saved. Goodbye!");
    }

    // Load goals and score from a file
    private void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isCompleted = bool.Parse(parts[4]);
                            var simpleGoal = new SimpleGoal(name, description, points);
                            simpleGoal.SetCompletionStatus(isCompleted);
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "ChecklistGoal":
                            int currentCount = int.Parse(parts[4]);
                            int targetCount = int.Parse(parts[5]);
                            int bonusPoints = int.Parse(parts[6]);
                            var checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints)
                            {
                                CurrentCount = currentCount
                            };
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
        }
    }
}
