using System;

public class Assignment
{
    //Protected member variables that can be accessed by derived classes
    protected string _studentName;
    protected string _topic;
    
    //Constructor to initialize member variables
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Method to return a summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}