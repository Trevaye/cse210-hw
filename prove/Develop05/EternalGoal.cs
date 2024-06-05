public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // No completion for eternal goals, just add points
    public override void RecordEvent()
    {
        // Eternal goals are never complete
    }

    // Eternal goals are never complete
    public override bool IsComplete() => false;

    // Return details of the goal
    public override string GetDetailsString() => $"[Eternal Goal] {GetName()}: {GetDescription()} - Points: {GetPoints()}";

    // Return a string representation for saving to a file
    public override string GetStringRepresentation() => $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
}