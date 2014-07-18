using System;

class MatrixOfNumbers
{
    static void Main()
    {
        char choice;
        while (true)
        {
            //I don't use 2 loops because I wanted to do the problem with an array. The solution with 2 loops would be the same but
            //instead of giving the value of variable k to the array, you should print it directly to the console

            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int k = 1;

            int[,] numbers = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n ; j++)
                {
                    numbers[i, j] = k;
                    k++;
                }
                k = i + 2;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(numbers[i, j] + " ");   
                }
                Console.WriteLine();
            }

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}