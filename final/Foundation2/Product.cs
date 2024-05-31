using System;

// Class representing a product in an order
public class Product
{
    // Private fields
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    // Constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to calculate the total cost of the product
    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    // Properties to access the product details
    public string Name => name;
    public string ProductId => productId;
}