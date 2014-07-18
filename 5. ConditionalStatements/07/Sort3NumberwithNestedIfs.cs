using System;

class Sort3NumberwithNestedIfs
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

            if(a>=b && a>=c)
            {
                if(b>=c)
                {
                    Console.WriteLine("{0}, {1}, {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", a, c, b);
                }
            }

            else if (b >= c && b >= a)
            {
                if (a >= c)
                {
                    Console.WriteLine("{0}, {1}, {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", b, c, a);
                }
            }

            else if (c >= b && c >= a)
            {
                if (b >= a)
                {
                    Console.WriteLine("{0}, {1}, {2}",c , b, a);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", c, a, b);
                }
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