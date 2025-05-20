using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction two = new Fraction(5);
        Fraction three = new Fraction(3, 4);
        Fraction four = new Fraction();
        four.SetTop(1);
        four.SetBottom(3);

        Console.WriteLine($"{one.GetTop()}/{one.GetBottom()}");
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine($"{two.GetTop()}/{two.GetBottom()}");
        Console.WriteLine(two.GetDecimalValue());
        Console.WriteLine($"{three.GetTop()}/{three.GetBottom()}");
        Console.WriteLine(three.GetDecimalValue());
        Console.WriteLine($"{four.GetTop()}/{four.GetBottom()}");
        Console.WriteLine(four.GetDecimalValue());
    }

}