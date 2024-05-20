using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    // List of prompts for the listing activity
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor to initialize the listing activity with a name and description
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    // Override the Run method to perform the listing activity
    public override void Run()
    {
        DisplayStartingMessage(); // Show the starting message

        // Get a random prompt and display it
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowSpinner(3); // Show a spinner for 3 seconds

        // Get the list of items from the user
        List<string> items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} items."); // Display the number of items listed

        DisplayEndingMessage(); // Show the ending message
    }

    // Method to get a random prompt from the list
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    // Method to get the list of items from the user
    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration - 3); // Calculate the end time

        // Collect items from the user until the time is up
        while (DateTime.Now < endTime)
        {
            Console.Write("List an item: ");
            items.Add(Console.ReadLine());
        }

        return items;
    }
}
