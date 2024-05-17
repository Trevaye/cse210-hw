using System;

public class WritingAssignment : Assignment
{
    //Variable
    private string _title;

    //Constructor
    public WritingAssignment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title = title;
    }

    //Method to return writing information
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}