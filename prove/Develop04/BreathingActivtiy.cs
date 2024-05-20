public class BreathingActivity : Activity
{
    // Constructor to initialize the breathing activity with a name and description
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing exercises.")
    {
    }

    // Override the Run method to perform the breathing activity
    public override void Run()
    {
        DisplayStartingMessage(); // Show the starting message

        // Alternate between "Breathe in..." and "Breathe out..." messages
        for (int i = 0; i < _duration; i += 4)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(2); // Show countdown for 2 seconds
            Console.WriteLine("Breathe out...");
            ShowCountDown(2); // Show countdown for 2 seconds
        }

        DisplayEndingMessage(); // Show the ending message
    }
}
