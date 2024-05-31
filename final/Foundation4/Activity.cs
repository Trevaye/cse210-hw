public class Activity
{
    // Properties for common activity attributes
    public DateTime Date { get; set; }
    public int Length { get; set; } // Length in minutes

    // Constructor
    public Activity(DateTime date, int length)
    {
        Date = date;
        Length = length;
    }

    // Virtual methods to be overridden by derived classes
    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    // Method to get summary (can be overridden if needed)
    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} Activity ({Length} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
}