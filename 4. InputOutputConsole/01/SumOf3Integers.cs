using System;

class SumOf3Integers
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input first int: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Input second int: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Input third int: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("'The sum of these is " + (n1 + n2 + n3));

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if(choice!='y' && choice != 'Y')
            {
                break;
            }

        }
    }
}