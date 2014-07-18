using System;

class PrinteADeckOf52Cards
{
    enum CardNames
    {
        J = 11, 
        Q = 12,
        K = 13,
        A = 14
    }

    static void Main()
    {
        char choice;
        while (true)
        {
            for (int i = 2; i < 15; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (i > 10)
                    {
                        Console.Write(Enum.GetName(typeof(CardNames), i));
                    }
                    else
                    {
                        Console.Write(i);
                    }

                    switch (j)
                    {
                        case 1: Console.Write("♣ ");
                            break;
                        case 2: Console.Write("♦ ");
                            break;
                        case 3: Console.Write("♥ ");
                            break;
                        case 4: Console.Write("♠ ");
                            break;
                            
                        default: Console.WriteLine("Error");
                            break;
                    }
                }
                Console.WriteLine();
                
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