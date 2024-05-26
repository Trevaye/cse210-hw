using System;

// Base class
public abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;

    public Goal(string name, string description, int points )
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Method to record
    public abstract void RecordEvent();
    // Method to check if goal is complete
    public abstract bool IsComplete();
    //Methoud to get the foal details as a string
    public abstract string GetDetailsString();
    //Method to get the string representation for the goal for saving
    public abstract string GetStringRepresentation();
}