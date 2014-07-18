using System;

class Program
{
    static void Main()
    {
        int w;
        int h;
        Console.Write("Input width: ");
        w=int.Parse(Console.ReadLine());
        Console.Write("Input height: ");
        h = int.Parse(Console.ReadLine());
        Console.WriteLine("The area is " + (h*w));
        Console.WriteLine("The perimeter is " + (h + w));
    }
}

