using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Activity running = new Running(new DateTime(2024, 5, 1), 30, 3.0); // 3 miles in 30 minutes
        Activity cycling = new Cycling(new DateTime(2024, 5, 2), 45, 15.0); // 15 mph for 45 minutes
        Activity swimming = new Swimming(new DateTime(2024, 5, 3), 60, 20); // 20 laps in 60 minutes

        // Store activities in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Iterate through the list of activities and display their summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    } 
}