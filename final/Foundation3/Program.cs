using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Oak St", "Los Angeles", "CA", "USA");

        // Create events
        Event lecture = new Lecture("Understanding OOP", "A deep dive into object-oriented programming.", new DateTime(2024, 6, 15), "10:00 AM", address1, "Dr. John Smith", 100);
        Event reception = new Reception("Company Annual Meeting", "Annual meeting for all employees.", new DateTime(2024, 6, 20), "5:00 PM", address2, "rsvp@company.com");
        Event outdoorGathering = new OutdoorGathering("Summer Picnic", "Company summer picnic.", new DateTime(2024, 7, 10), "12:00 PM", address3, "Sunny");

        // Store events in a list
        List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

        // Iterate through the list of events and display their information
        foreach (var ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(new string('-', 40)); // Separator line for better readability
        }
    }
}