using System;

class Program
{
    static void Main(string[] args)
    {
        // Sample scripture
        var scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Display the complete scripture
        DisplayScripture(scripture);

        // Hide words until all are hidden
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2); // Hide 2 words at a time
            DisplayScripture(scripture);
        }
    }

    static void DisplayScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}