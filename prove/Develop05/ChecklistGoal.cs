public class ChecklistGoal : Goal
{
    private int _amountCompleted; // Count of how many times the goal has been completed
    private int _target; // Target count to complete the goal
    private int _bonus; // Bonus points for completing the goal

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    // Increment the count of completed steps
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    // Check if the goal is complete
    public override bool IsComplete() => _amountCompleted >= _target;

    // Return details of the goal
    public override string GetDetailsString() => $"[Checklist Goal] {GetName()}: {GetDescription()} - Points: {GetPoints()} - Completed: {_amountCompleted}/{_target}";

    // Return a string representation for saving to a file
    public override string GetStringRepresentation() => $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";

    // Getter for bonus points
    public int GetBonus() => _bonus;
}
