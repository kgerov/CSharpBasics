using System;

class Program
{
    static void Main()
    {
        char uni='H';
        Console.WriteLine("The letter {0} has a code {1}", uni, (int)uni);

        uni = (char)72;
        Console.WriteLine("The code {0} corresponds to the number {1}", (int)uni, uni);

    }
}

