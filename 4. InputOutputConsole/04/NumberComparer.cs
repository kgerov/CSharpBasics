using System;

class NumberComparer
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("First Number: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("The bigger number is: " + Math.Max(n,m));


            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}