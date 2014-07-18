using System;
class Program
{
    static void Main()
    {
        
        
        Console.Write("Input int: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Input position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Input value to be changed: ");
        int v = int.Parse(Console.ReadLine());

        int mask;
        int result=0;

        if (v == 0)
        {
            v = 1;
            mask = ~(v << p);
            result = mask & num;
        }
        else if (v == 1)
        {
            mask = v << p;
            result = mask | num;
        }

        

        Console.WriteLine(result);
    

    }
}
