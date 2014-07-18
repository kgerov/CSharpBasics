using System;

class Program
{
    static void Main()
    {
        Console.Write("Type number: ");
        int a = int.Parse(Console.ReadLine());
        if(a%5==0 && a%7==0)
        {
            Console.WriteLine("IT CAN BE DIVIDED");
        }
        else
        {
            Console.WriteLine("GO BACK TO FIRST GRADE!");
        }
    }
}

