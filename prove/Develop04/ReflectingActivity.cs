using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    // List of prompts for the reflecting activity
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    // List of questions for the reflecting activity
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // Constructor to initialize the reflecting activity with a name and description
    public ReflectingActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    // Override the Run method to perform the reflecting activity
    public override void Run()
    {
        DisplayStartingMessage(); // Show the starting message

        // Display a random prompt and questions
        DisplayPrompt();
        DisplayQuestions();

        DisplayEndingMessage(); // Show the ending message
    }

    // Method to get a random prompt from the list
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    // Method to get a random question from the list
    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    // Method to display a random prompt
    private void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3); // Show a spinner for 3 seconds
    }

    // Method to display random questions until the duration is up
    private void DisplayQuestions()
    {
        int remainingTime = _duration - 3; // Calculate remaining time

        // Display random questions and show a spinner after each question
        while (remainingTime > 0)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(5); // Show a spinner for 5 seconds
            remainingTime -= 5;
        }
    }
}
