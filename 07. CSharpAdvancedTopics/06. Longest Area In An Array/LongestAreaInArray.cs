using System;

class LongestAreaInArray
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("How many elements do you want to input: ");
            int NumberOfElements = int.Parse(Console.ReadLine());
            string[] UserElements = new string[NumberOfElements];

            for (int i = 0; i < NumberOfElements; i++)
            {
                Console.Write("Input: ");
                UserElements[i] = Console.ReadLine();
            }

            string MaxSeqName = UserElements[0];
            int MaxCounter = 1;
            int TempCounter = 1;

            for (int i = NumberOfElements - 1; i >= 0; i--)
            {
                if (i == 0) //Condition to check last iteration
                {
                    if (MaxCounter == TempCounter) 
                    {
                        MaxSeqName = UserElements[i];
                    }
                }
                else
                {

                    if (UserElements[i] == UserElements[i - 1]) //Loop to check all the other iterations
                    {
                        TempCounter++;
                    }
                    else
                    {
                        TempCounter = 1;
                    }

                    if (TempCounter >= MaxCounter)
                    {
                        MaxCounter = TempCounter;
                        MaxSeqName = UserElements[i];
                    }
                }
            }

            Console.WriteLine(MaxCounter);
            for (int i = 0; i < MaxCounter; i++)
            {
                Console.WriteLine(MaxSeqName);
            }

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }
            Console.WriteLine(new string('-', 30));
        }
    }
}