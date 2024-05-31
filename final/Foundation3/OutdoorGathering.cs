public class OutdoorGathering : Event
{
    // Additional property for outdoor gathering-specific attribute
    public string Weather { get; set; }

    // Constructor
    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    // Override method to get full details
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {Weather}";
    }

    // Override method to get short description
    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {base.GetShortDescription()}";
    }
}