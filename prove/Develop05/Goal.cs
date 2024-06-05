public abstract class Goal
{
    private string _name; // Goal name
    private string _description; // Goal description
    private int _points; // Points awarded for the goal

    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Abstract methods to be implemented by derived classes
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    // Getter methods for goal properties
    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;
}