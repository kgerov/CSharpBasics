using System;
    class Program
    {
        static void Main()
        {

            Console.Write("Input: ");
            int x = int.Parse(Console.ReadLine());
            int p = 3;
            int XRightP = x >> p;
            int result = XRightP & 1;
            Console.WriteLine("The third bit is: " + result);
            }

    }
