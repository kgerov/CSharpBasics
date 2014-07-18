using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int max=0;
            int min=0;
            int sum = 0;
            int num;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Input int: ");
                num = int.Parse(Console.ReadLine());

                if (i==0)
                {
                    max = num;
                    min = num;
                }
                
                if(num>=max)
                {
                    max = num;
                }

                if(num<=min)
                {
                    min = num;
                }

                sum += num;
            }

            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + sum/2.0);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}