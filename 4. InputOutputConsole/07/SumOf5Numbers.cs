using System;

class SumOf5Numbers
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input: ");
            string[] tokens = Console.ReadLine().Split();

            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int c = int.Parse(tokens[2]);
            int d = int.Parse(tokens[3]);
            int e = int.Parse(tokens[4]);

            int sum = a + b + c + d + e;

            Console.WriteLine(sum);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}