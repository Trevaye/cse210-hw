using System;
using System.Threading;

public abstract class Activity
{
    // Protected member variables
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor to initialize the activity name and description
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Method to display the starting message and set the duration
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); // Show a spinner for 3 seconds
    }

    // Method to display the ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You've completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3); // Show a spinner for 3 seconds
    }

    // Method to show a spinner animation for a given number of seconds
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // Wait for 1 second
        }
        Console.WriteLine();
    }

    // Method to show a countdown for a given number of seconds
    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000); // Wait for 1 second
        }
        Console.WriteLine();
    }

    // Abstract method to be implemented by derived classes
    public abstract void Run();
}
