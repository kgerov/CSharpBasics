using System;

class PalindromesMatrix
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Input columns: ");
            int col = int.Parse(Console.ReadLine());
            int CurrLetter = 97;
            int MiddleLetter = CurrLetter;

            for (int i = 0; i < row; i++)
            {               
                for (int j = 0; j < col; j++)
                {
                    Console.Write("{0}{1}{2} ", (char)CurrLetter, (char)MiddleLetter, (char)CurrLetter);
                    MiddleLetter++;
                }
                Console.WriteLine();
                CurrLetter++;
                MiddleLetter = CurrLetter;
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