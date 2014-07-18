using System;

class Program
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;
        byte temp;
        Console.WriteLine("a and b hold the values of: {0} and {1}", a, b);
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("a and b hold the values of: {0} and {1}", a, b);
    }
}


