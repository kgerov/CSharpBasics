using System;

class NumbersNotDivisableBy3And7
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    

                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}