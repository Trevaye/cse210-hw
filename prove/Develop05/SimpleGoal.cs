public class SimpleGoal : Goal
{
    private bool _isComplete; // Flag to indicate if the goal is complete

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Mark the goal as complete
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    // Check if the goal is complete
    public override bool IsComplete() => _isComplete;

    // Return details of the goal
    public override string GetDetailsString() => $"[Simple Goal] {GetName()}: {GetDescription()} - Points: {GetPoints()} - Complete: {(_isComplete ? "[X]" : "[ ]")}";

    // Return a string representation for saving to a file
    public override string GetStringRepresentation() => $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
}