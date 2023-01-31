using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("\nHello Learning03 World!\n");

        Fraction f1 = new Fraction();
        // Console.WriteLine($"{f1.GetTop()}/{f1.GetBottom()}");
        // f1.SetTop(3);
        // f1.SetBottom(4);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        
        Fraction f2 = new Fraction(5);
        // Console.WriteLine($"{f2.GetTop()}/{f2.GetBottom()}");
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        
        Fraction f3 = new Fraction(3,4);
        // Console.WriteLine($"{f3.GetTop()}/{f3.GetBottom()}");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
        Fraction f4 = new Fraction();
        f4.SetBottom(3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}