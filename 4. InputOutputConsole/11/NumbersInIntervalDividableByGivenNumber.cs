using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("End: ");
            int end = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                    p++;
            }

            Console.WriteLine("Result: " + p);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}