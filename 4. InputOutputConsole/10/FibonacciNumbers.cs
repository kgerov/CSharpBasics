using System;

class  FibonacciNumbers
{
    static void Main()
    {
        char choice;
        while (true)
        {
            int a = 0;
            int b = 1;
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(a);
            }


            for (int i = 1; i < n; i++)
            {
                if (n == 2)
                {
                    Console.WriteLine(a + ", " + b);
                    break;
                }
                if (i == 1)
                {
                    Console.Write(a + ", ");
                }

                if (i % 2 == 0)
                {
                    a += b;
                    Console.Write(a + ", ");
                }

                if (i % 2 != 0)
                {
                    b += a;
                    Console.Write(b + ", ");
                }
            }

            Console.WriteLine();

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}