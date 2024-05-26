// EternalGoal class inheriting from Goal
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    // Record an event for the eternal goal
    public override void RecordEvent()
    {
        Console.WriteLine($"[Recorded] Goal '{_shortName}' recorded! You earned {_points} points!");
    }

    // Eternal goals are never complete
    public override bool IsComplete()
    {
        return false;
    }

    // Get the goal details as a string
    public override string GetDetailsString()
    {
        return $"{_shortName} - {_description} ({_points} points) [Eternal]";
    }

    // Get the string representation of the goal for saving
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}