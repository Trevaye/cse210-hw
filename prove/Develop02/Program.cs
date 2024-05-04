using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator(new List<string> {"What's on your mind today?", "Describe a memorable moment."});

        while (true)
        {
          Console.WriteLine("Menu:");
          Console.WriteLine("1. Write a new entry");
          Console.WriteLine("2. Display the journal");
          Console.WriteLine("3. Save the journal to a file");
          Console.WriteLine("4. Load the journal from a file");
          Console.WriteLine("5. Exit");  

          Console.Write("Enter your choice: ");
          string choice = Console.ReadLine();

          switch (choice)
          {
            case "1":
            Console.WriteLine("Generating a random prompt....");
            string randomPrompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine($"Prompt: {randomPrompt}");
            Console.Write("Enter your response: ");
            string entryText = Console.ReadLine();
            journal.AddEntry(new Entry(DateTime.Now.ToString("yyyy-MM-dd"), randomPrompt, entryText));
            break;

            case "2":
            Console.WriteLine("Displaying the journal:");
            journal.DisplayAll();
            break;

            case "3":
            Console.Write("Enter the filename to save the journal to: ");
            string saveFileName = Console.ReadLine();
            journal.SaveToFile(saveFileName);
            Console.WriteLine("Journal saved to file.");
            break;

            case "4":
            Console.Write("Enter the filename to load the journal from: ");
            string loadFileName = Console.ReadLine();
            journal.LoadFromFile(loadFileName);
            Console.WriteLine("Journal loaded from file.");
            break;

            case "5":
            Console.WriteLine("Exiting the program.");
            return;

            default:
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5");
            break;
          }
        }
    }
}