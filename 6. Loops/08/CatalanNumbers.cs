using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        char choice;
        while (true)
        {
            BigInteger n;

            do
            {
                Console.Write("Input n: ");
                n = BigInteger.Parse(Console.ReadLine());

            } while (n < 1 || n > 100); //In the task it is said without zero and in the examples there is a zero??

            BigInteger factorial = 1;

            for (BigInteger i = 2 * n; i > n; i--)
            {
                factorial *= i;
            }
            BigInteger factorial2 = 1;

            for (BigInteger i = n + 1; i > 1; i--)
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