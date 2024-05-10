using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a Fraction object with default constructor (1/1)
        Fraction f1 = new Fraction();
        // Printing the fraction and the decimal
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Creating a Fraction object with default constructor (5/1)
        Fraction f2 = new Fraction(5);
        // Printing the fraction and the decimal 
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Creating a Fraction object with default constructor (3/4)
        Fraction f3 = new Fraction(3, 4);
        // Printing the fraction and the deciaml
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Creating a Fraction object with default constructor (1/3)
        Fraction f4 = new Fraction(1, 3);
        // Printing the fraction and the decimal
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}