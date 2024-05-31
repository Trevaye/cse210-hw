public class Address
{
    // Properties for address attributes
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    // Constructor
    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    // Method to return the full address as a string
    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}