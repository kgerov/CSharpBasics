using System;

class SumOfFactorials
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input x: ");
            int x = int.Parse(Console.ReadLine());
            int factorial=1;

            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial / (Math.Pow(x, i));
            }
            Console.WriteLine("{0:F5}",sum);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}