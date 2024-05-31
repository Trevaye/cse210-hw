public class Running : Activity
{
    // Additional property for running-specific attribute
    public double Distance { get; set; } // Distance in miles

    // Constructor
    public Running(DateTime date, int length, double distance)
        : base(date, length)
    {
        Distance = distance;
    }

    // Override methods to provide specific calculations for running
    public override double GetDistance() => Distance;
    public override double GetSpeed() => (Distance / Length) * 60;
    public override double GetPace() => Length / Distance;
}