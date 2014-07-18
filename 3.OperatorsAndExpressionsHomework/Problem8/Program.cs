using System;

class Program
{
    static void Main()
    {
        Console.Write("Input integer: ");
        int x = int.Parse(Console.ReadLine());
        bool flag = true;

        for (int i = 2; i < x; i++)
        {

            if (x % i == 0)
                flag = false;
        }

        if (x <= 1)
            flag = false;

            if (flag == true)
            {
                Console.WriteLine("Int is prime");
            }
            else
            {
                Console.WriteLine("int is not prime");
            }
    }
}

