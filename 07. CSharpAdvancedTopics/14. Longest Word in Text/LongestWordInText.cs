using System;

class LongestWordInText
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input text: ");

            string word = "";
            string LongestWord = "";
            int maxLength = 0;
            int index = 0;
            while (true)
            {
                int letter = Console.Read();
                if (letter == 13 || letter == 10)
                {
                    letter = Console.Read();
                    break;
                }
                if (letter == ' ' || letter == 46)
                {
                    if (word.Length>=maxLength)
                    {                       
                        LongestWord = word;
                        maxLength = word.Length;
                    }
                    word = "";
                    index = 0;
                    continue;
                }
                word = word.Insert(index, Convert.ToString((char)letter));
                index++;
            }

            Console.WriteLine(LongestWord);

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