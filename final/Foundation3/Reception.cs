public class Reception : Event
{
    // Additional property for reception-specific attribute
    public string RSVPEmail { get; set; }

    // Constructor
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        RSVPEmail = rsvpEmail;
    }

    // Override method to get full details
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {RSVPEmail}";
    }

    // Override method to get short description
    public override string GetShortDescription()
    {
        return $"Reception: {base.GetShortDescription()}";
    }
}