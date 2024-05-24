public class Rectangle : Shape
{
    // Private member variables to store the lengths of the sides
    private double _length;
    private double _width;

    // Constructor that sets the color, length, and width, and calls the base constructor
    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

     // Override the GetArea method to calculate the area of the rectangle
    public override double GetArea()
    {
        return _length * _width;
    }
}