using System;
using System.Collections.Generic;
using System.Linq;

class PrimesInRange
{
    static List<int> FindPrimesInRange(int RangeStart,int RangeEnd)
    {
        List<int> PrimeRange = new List<int>();
        int devider = 2;

        for (int i = RangeStart; i <= RangeEnd; i++)
        {
            int MaxDevider = Convert.ToInt32(Math.Sqrt(i));
            bool isPrime = true;
            if (i == 1 || i == 0)
            {
                continue;
            }
            for (int j = devider; j <= MaxDevider; j++)
            {
                if (i%j == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime == true)
            {
                PrimeRange.Add(i);
            }
        }

        return PrimeRange;
    }

    static void PrintListOfPrimes(List<int> PrimeRange)
    {
        for (int i = 0; i < PrimeRange.Count; i++)
        {
            Console.Write(PrimeRange[i]);
            if (i < PrimeRange.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Range beginning: ");
            int RangeStart = int.Parse(Console.ReadLine());
            Console.Write("Range end: ");
            int RangeEnd = int.Parse(Console.ReadLine());
            List<int> PrimeRange = new List<int>();

            PrimeRange = FindPrimesInRange(RangeStart, RangeEnd);
            PrintListOfPrimes(PrimeRange);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }
            Console.WriteLine(new string('-', 30));
        }
    }
}