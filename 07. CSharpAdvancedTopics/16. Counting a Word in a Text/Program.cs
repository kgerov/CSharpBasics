//There are 2 mistakes in the examples in this problem
using System;

class WordCount
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Word: ");
            string RepeatedWord = Console.ReadLine();
            Console.Write("Text: ");
            RepeatedWord = RepeatedWord.ToLower();

            int index = 0;
            string text = "";
            int counter = 0;

            while (true)
            {
                int a = Console.Read();
                if (a == 13)
                {
                    a = Console.Read();
                    break;
                }
                else
                {
                    text = text.Insert(index, Convert.ToString((char)a));
                    index++;
                }
            }

            string[] CleanText = text.Split(new char[] { ',', ';', ' ', '!', '.','?', ':', '"', '\'','/', '@'},
            StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in CleanText)
            {
                if(item.ToLower().Contains(RepeatedWord) == true)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

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