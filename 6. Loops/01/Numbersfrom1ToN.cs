using System;

class Numbersfrom1ToN
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine(i);
                    break;
                }

                Console.Write("{0}, ", i);
            }

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if(choice!='y' && choice != 'Y')
            {
                break;
            }

        }
    }
}