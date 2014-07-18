using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a 4-digit number: ");
        int x = int.Parse(Console.ReadLine());
        int a = x % 10;
        int b = (x - a) / 10 % 10;
        int c = (x - 10 * b - a) / 100 % 10;
        int d = (x - 100 * c - 10 * b - a) / 1000 % 10;

        Console.WriteLine("Sum of digits is " + (a+b+c+d));
        Console.WriteLine("The number in reverse: " + a+b+c+d);
        Console.WriteLine("Last digit in first place: " + a + d + c +b);
        Console.WriteLine("Exchange of second and third digit: " + d+b+c+a);
    }
}

