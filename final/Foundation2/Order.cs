public class Order
{
    // Private fields
    private List<Product> products;
    private Customer customer;

    // Constructor
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate the total cost of the order
    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }
        total += customer.IsInUSA() ? 5 : 35; // Add shipping cost
        return total;
    }

    // Method to get the packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} ({product.ProductId})\n";
        }
        return label;
    }

    // Method to get the shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address.GetFullAddress()}";
    }
}