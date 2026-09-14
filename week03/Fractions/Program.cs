using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        
        // constructor 1: 1/1
        Fraction f1 = new Fraction(); 
        Console.WriteLine($"Fraction 1: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal 1: {f1.GetDecimalValue()}");
        Console.WriteLine();

        // constructor 2: 5/1
        Fraction f2  = new Fraction(5); // <- changed this to pass 6
        Console.WriteLine($"Fraction 2: {f2.GetFractionString()}");
        Console.WriteLine($"Decimal 2: {f2.GetDecimalValue()}");
        Console.WriteLine();
        
        // constructor 3: 3/4
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 3: {f3.GetFractionString()}");
        Console.WriteLine($"Decimal 3: {f3.GetDecimalValue()}");

        Console.WriteLine();
        Console.WriteLine("---- Testing getters and setters ----");

        //Use getters to get current values
        Console.WriteLine($"f3 Numerator: {f3.GetNumerator()}");
        Console.WriteLine($"f3 Denominator: {f3.GetDenominator()}");
        
        //Use setters to change values
        f3.SetNumerator(3);
        f3.SetDenominator(4);
        Console.WriteLine($"f3 after changes: {f3.GetFractionString()}");
        Console.WriteLine($"f3 Decimal after changes: {f3.GetDecimalValue()}");
        Console.WriteLine();

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"{f4.GetFractionString()} = {f4.GetDecimalValue()}");

        Fraction f5 = new Fraction(5, 8);
        Console.WriteLine($"{f5.GetFractionString()} = {f5.GetDecimalValue()}");
       
    }
} 