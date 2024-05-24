public class Square : Shape
{
    // Private member variable to store the side length of the square
    private double _side;

    // Constructor that sets the color and side length, and calls the base constructor
    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    // Override the GetArea method to calculate the area of the square
    public override double GetArea()
    {
        return _side * _side;
    }
}