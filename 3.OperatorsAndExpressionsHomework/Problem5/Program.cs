using System;

class Program
{
    static void Main()
    {
        Console.Write("Input number: ");
        int x = int.Parse(Console.ReadLine());
        int a = x % 10;
        int b = (x - a)/10 % 10;
        int c = (x - 10 * b - a) / 100 % 10;

        if(c==7)
            Console.WriteLine("The thrid digit of the number is 7");
        else
            Console.WriteLine("The third digit is not seven");
    }
}

