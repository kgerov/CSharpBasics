using System;

class SumOfNNumbers
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            double a;

            double sum = 0;
            
            for(int i = n; i>0; i--)
            {
                Console.Write("New Number: ");
                a = double.Parse(Console.ReadLine());
                sum += a;
            }

            Console.WriteLine("The sum is " + sum);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}