using System;

class Combinatorics
{
    static void Main()
    {
        char choice;
        while (true)
        {
            int k, n;
            do
            {
                Console.Write("Input n: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Input k: ");
                k = int.Parse(Console.ReadLine());

            } while (k < 1 || k > 100 || n < 1 || n > 100 || k > n);

            int factorial = 1;

            for (int i = n; i > k; i--)
            {
                factorial *= i;
            }

            int factorial2 = 1;
            for (int i = (n - k); i > 1;i-- )
            {
                factorial2 *= i;
            }
            Console.WriteLine(factorial/factorial2);

                Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}