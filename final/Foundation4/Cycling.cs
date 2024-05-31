public class Cycling : Activity
{
    // Additional property for cycling-specific attribute
    public double Speed { get; set; } // Speed in mph

    // Constructor
    public Cycling(DateTime date, int length, double speed)
        : base(date, length)
    {
        Speed = speed;
    }

    // Override methods to provide specific calculations for cycling
    public override double GetDistance() => (Speed * Length) / 60;
    public override double GetSpeed() => Speed;
    public override double GetPace() => 60 / Speed;
}