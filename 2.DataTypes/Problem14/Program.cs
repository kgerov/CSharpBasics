using System;

namespace Homework
{
class Program
{
    static void Main()
    {
        byte asc;
        Console.WriteLine("ASC II TABLE");
        for (asc = 0; asc < 255; asc++)
        {
            Console.WriteLine("The number {0} is the letter {1}", asc, (char)asc);
        }
    }
}
}