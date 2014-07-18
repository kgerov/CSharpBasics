using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Input: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Input: ");
            double e = double.Parse(Console.ReadLine());

            double max = a;

            if (max < b)
                max = b;
            if (max < c)
                max = c;
            if (max < d)
                max = d;
            if (max < e)
                max = e;

            Console.WriteLine(max);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}