using System;

class CheckForAPlayCard
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input card: ");
            string card = Console.ReadLine();
            int card1;
            char card2;
            bool flag = false;

            if (card == "A" || card == "K" || card == "Q" || card == "J")
            {
                Console.WriteLine("Yes");
                flag = true;
            }
            else 
            {
                card2 = char.Parse(card);
                card1 = (int)card2;
                for (int i = 2; i < 11; i++)
                {
                    if(card1==i)
                    {
                        Console.WriteLine("Yes");
                        flag = true;
                        break;
                    }
                }
                
            }

            if(flag==false)
                Console.WriteLine("No");

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}