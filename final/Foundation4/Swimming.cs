public class Swimming : Activity
{
    // Additional property for swimming-specific attribute
    public int Laps { get; set; } // Number of laps

    // Constructor
    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        Laps = laps;
    }

    // Override methods to provide specific calculations for swimming
    public override double GetDistance() => Laps * 50 / 1000 * 0.62; // Convert meters to miles
    public override double GetSpeed() => (GetDistance() / Length) * 60;
    public override double GetPace() => Length / GetDistance();
}