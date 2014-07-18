using System;
using System.Linq;

class LongestNonDecreasingSubsequence
{
    static void FindLongestSubSequenceSize(int[] sequence, ref int LongestSequenceIteration, ref int MaxCounter)
    {
        int CurrCounter = 1;
        int MaxNumber = sequence.Max();

        for (int i = 0; i < sequence.Length; i++)
        {
            CurrCounter = 1;
            int CurrNumber = sequence[i];
            int NextNumber = CurrNumber + 1; 
            int t = i + 1;

            while (NextNumber <= MaxNumber)
            {
                for (int j = t; j < sequence.Length; j++)
                {
                    if (NextNumber == sequence[j])
                    {
                        CurrCounter++;
                        t = j;
                        break; 
                    }
                }

                NextNumber++;
            }


            if (CurrCounter > MaxCounter)
            {
                MaxCounter = CurrCounter;
                LongestSequenceIteration = i;
            }
        }
    }

    static void FindSequence (int[] sequence, int MaxCounter, int LongestSequenceIteration, ref int[] TheSequence)
    {
        int CurrNumber = sequence[LongestSequenceIteration];
        int NextNumber = CurrNumber + 1;
        int t = LongestSequenceIteration + 1;
        int MaxNumber = sequence.Max();

        TheSequence[0] = CurrNumber;

        int i = 1;
        while (NextNumber <= MaxNumber)
        {
            for (int j = t; j < sequence.Length; j++)
            {
                if (NextNumber == sequence[j])
                {
                    TheSequence[i] = NextNumber;
                    t = j;
                    i++;
                    break;
                }
            }

            NextNumber++;
        }
    }

    static void FindEqualNumberSequence (int[] sequence, ref int LongestSequenceIteration, ref int MaxCounter, ref bool flag)
    {
        int Smallest = sequence.Min();
        int Biggest = sequence.Max();
        int CurrNumber = Smallest;
        int CurrCounter = 0;

        while (CurrNumber <= Biggest)
        {
            CurrCounter = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == CurrNumber)
                {
                    CurrCounter++;
                }
            }

            if (CurrCounter > MaxCounter)
            {
                MaxCounter = CurrCounter;
                LongestSequenceIteration = CurrNumber;
                flag = true;
            }
            CurrNumber++;
        }
    }
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input sequence: ");               //This problem is writen in an awful way but it was a long day 
            string[] tokens = Console.ReadLine().Split();
            int[] sequence = new int[tokens.Length];
            bool flag = false;

            for (int i = 0; i < tokens.Length; i++)
            {
                sequence[i] = int.Parse(tokens[i]);
            }
            int LongestSequenceIteration = 0;
            int MaxCounter = 0;

            FindLongestSubSequenceSize(sequence, ref LongestSequenceIteration, ref MaxCounter);
            int[] TheSequence = new int[MaxCounter];
            FindSequence(sequence, MaxCounter, LongestSequenceIteration, ref TheSequence);

            FindEqualNumberSequence(sequence, ref LongestSequenceIteration, ref MaxCounter, ref flag);

            if (flag == false)
            {
                for (int i = 0; i < TheSequence.Length; i++)
                {
                    Console.Write("{0} ", TheSequence[i]);
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < MaxCounter; i++)
                {
                    Console.Write("{0} ", LongestSequenceIteration);
                }
                Console.WriteLine();
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