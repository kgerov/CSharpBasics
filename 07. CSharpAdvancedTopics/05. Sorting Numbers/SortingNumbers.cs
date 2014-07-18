using System;

class SortingNumbers
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("How many numbers you wanna sort: ");
            int Amount = int.Parse(Console.ReadLine());
            int[] UsersNumbers = new int[Amount];

            for (int i = 0; i < Amount; i++)
            {
                Console.Write("Input: ");
                UsersNumbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(UsersNumbers);

            for (int i = 0; i < UsersNumbers.Length; i++)
            {
                Console.WriteLine(UsersNumbers[i]);
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