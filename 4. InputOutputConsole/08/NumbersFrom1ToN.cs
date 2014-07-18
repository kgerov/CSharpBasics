using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = a; i > 0; i--)
            {
                if(i==1)
                {
                    Console.WriteLine(i);
                }
                Console.Write(i +", ");
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