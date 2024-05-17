using System;

public class MathAssignment : Assignment
{
    //More member variables specifically for MathAssignemt
    private string _textbookSection;
    private string _problems;

    //Constructor to initialize member variables, including base class variables
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //Method to return the homework list
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}