public class Customer
{
    // Private fields
    private string name;
    private Address address;

    // Constructor
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to check if the customer is in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Properties to access the customer details
    public string Name => name;
    public Address Address => address;
}