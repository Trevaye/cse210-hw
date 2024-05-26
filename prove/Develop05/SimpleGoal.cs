// SimpleGoal class inheriting from Goal
public class SimpleGoal : Goal
{
    public bool IsCompleted { get; private set; }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        IsCompleted = false;
    }

    // Mark the goal as complete
    public override void RecordEvent()
    {
        IsCompleted = true;
        Console.WriteLine($"[Success] Goal '{_shortName}' completed! You earned {_points} points!");
    }

    // Check if the goal is complete
    public override bool IsComplete()
    {
        return IsCompleted;
    }

    // Get the goal details as a string
    public override string GetDetailsString()
    {
        return $"{_shortName} - {_description} ({_points} points)";
    }

    // Get the string representation of the goal for saving
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{IsCompleted}";
    }

    // Method to set the completion status (for loading goals)
    public void SetCompletionStatus(bool isCompleted)
    {
        IsCompleted = isCompleted;
    }
}