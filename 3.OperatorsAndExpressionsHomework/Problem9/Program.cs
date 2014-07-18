using System;

class Program
{
    static void Main()
    {
        Console.Write("Input side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Input side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Input height: ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("The area of your trapezoid is: " + (((a+b)/2)*h));
    }
}

