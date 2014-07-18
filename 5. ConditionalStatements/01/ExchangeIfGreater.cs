using System;

class ExchangeIfGreater
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            double temp;

            if(a>b)
            {
                temp = a;
                a = b;
                b = temp; 
            }

            Console.WriteLine("First: {0}, Second {1}",a, b);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if(choice!='y' && choice != 'Y')
            {
                break;
            }

        }
    }
}