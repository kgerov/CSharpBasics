using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("First sequence: ");
            List<string> FirstNumbers = Console.ReadLine().Split().ToList();
            Console.Write("Second sequence: ");
            List<string> SecondNumbers = Console.ReadLine().Split().ToList();

            for (int i = 0; i < FirstNumbers.Count; i++)
            {
                for (int j = i + 1; j < FirstNumbers.Count; j++)
                {
                    if (FirstNumbers[i] == FirstNumbers[j])
                    {
                        FirstNumbers.RemoveAt(j);
                    }
                }
            }

            for (int i = 0; i < SecondNumbers.Count; i++)
            {
                bool Repeat = false;

                for (int j = 0; j < FirstNumbers.Count; j++)
                {
                    if (SecondNumbers[i] == FirstNumbers[j])
                    {
                        Repeat = true;
                    }
                }
                if (Repeat == false)
                {
                    FirstNumbers.Add(SecondNumbers[i]);
                }
            }

            List<int> FinalSequence = new List<int>();

            for (int i = 0; i < FirstNumbers.Count; i++)
            {
                FinalSequence.Add(int.Parse(FirstNumbers[i]));    
            }

            FinalSequence.Sort();

            foreach (var number in FinalSequence)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();

            

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