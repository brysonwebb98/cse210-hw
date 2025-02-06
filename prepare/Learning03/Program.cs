using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Fraction f1 = new Fraction();
        Console.WriteLine("BOTH FRACTIONS WITH NO PARAMETERS:");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine($"Decimal Value {f1.GetDecimalValue():F2}");
        Console.WriteLine("");

        Fraction f2 = new Fraction(22);
        Console.WriteLine("BOTH FRACTIONS WITH ONE PARAMETERS:");
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine($"Decimal Value {f2.GetDecimalValue():F2}");
        Console.WriteLine("");

        Fraction f3 = new Fraction(50, 44);
        Console.WriteLine("BOTH FRACTIONS WITH TWO PARAMETERS:");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine($"Decimal Value: {f3.GetDecimalValue():F2}");
        Console.WriteLine("");
    }

    
}