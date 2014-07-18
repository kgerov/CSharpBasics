using System;

class NFactorialOverKfactorial
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

            int factorial=1;

            for (int i = n; i > k; i--)
            {
                factorial *= i;

               
            }

            Console.WriteLine(factorial);

                Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}