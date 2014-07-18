using System;

class FibonacciNumbers
{
    static void FindFibNumber(int FibIndex)
    {
        int[] fibonacci = new int[FibIndex + 2];
        fibonacci[0] = 1;
        fibonacci[1] = 1;

        for (int i = 2; i < fibonacci.Length; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.WriteLine(fibonacci[FibIndex]);
    }
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Fibonacci number index: ");
            int FibIndex = int.Parse(Console.ReadLine());

            FindFibNumber(FibIndex);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}

