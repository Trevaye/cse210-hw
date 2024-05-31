using System;

// Base class representing a general event
public class Event
{
    // Properties for common event attributes
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }

    // Constructor
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    // Method to get standard details
    public virtual string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address.GetFullAddress()}";
    }

    // Method to get full details (to be overridden by derived classes)
    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    // Method to get short description (to be overridden by derived classes)
    public virtual string GetShortDescription()
    {
        return $"{Title} on {Date.ToShortDateString()}";
    }
}