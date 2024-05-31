public class Lecture : Event
{
    // Additional properties for lecture-specific attributes
    public string Speaker { get; set; }
    public int Capacity { get; set; }

    // Constructor
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    // Override method to get full details
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }

    // Override method to get short description
    public override string GetShortDescription()
    {
        return $"Lecture: {base.GetShortDescription()}";
    }
}