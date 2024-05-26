// ChecklistGoal class inheriting from Goal
public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    // Record progress towards the checklist goal
    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            if (CurrentCount == TargetCount)
            {
                Console.WriteLine($"[Success] Goal '{_shortName}' completed! You earned {_points} points and a bonus of {BonusPoints} points!");
            }
            else
            {
                Console.WriteLine($"[Progress] Goal '{_shortName}' recorded! You earned {_points} points! Completed {CurrentCount}/{TargetCount} times.");
            }
        }
    }

    // Check if the target count is reached
    public override bool IsComplete()
    {
        return CurrentCount >= TargetCount;
    }

    // Get the goal details as a string
    public override string GetDetailsString()
    {
        return $"{_shortName} - {_description} ({_points} points) - {CurrentCount}/{TargetCount} completed";
    }

    // Get the string representation of the goal for saving
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{CurrentCount}|{TargetCount}|{BonusPoints}";
    }
}