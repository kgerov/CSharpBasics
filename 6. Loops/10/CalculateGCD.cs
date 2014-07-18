using System;

class CalculateGCD
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            int b = int.Parse(Console.ReadLine());
            int temp;
            int r = -1;

            while (r != 0)
            {
                if (a > Math.Max(a, b))
                {
                    temp = b;
                    b = a;
                    a = temp;
                }

                r = a % b;

                if (r != 0)
                {
                    a = b;
                    b = r;
                }
            }

            Console.WriteLine("The GCD is: " + b);



            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}