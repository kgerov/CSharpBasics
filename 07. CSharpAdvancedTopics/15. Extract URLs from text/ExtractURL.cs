using System;

class ExtractURL
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input text: "); //Put a space at the end (after the dot)

            string word = "";
            int index = 0;
            while (true)
            {
                int letter = Console.Read();
                if (letter == 13 || letter == 10)
                {
                    letter = Console.Read();
                    break;
                }
                if (letter == ' ') 
                {
                    try
                    {
                        if (word[0] == 'h' && word[1] == 't' && word[2] == 't' && word[3] == 'p' && word[4] == ':')
                        {
                            if (word[word.Length-1] != 'm' && word[word.Length-1] != 'g')
                            {
                                word = word.Remove(word.Length - 1);
                            }
                            Console.WriteLine(word);
                        }
                        else if (word[0] == 'w' && word[1] == 'w' && word[2] == 'w' && word[3] == '.')
                        {
                            if (word[word.Length - 1] != 'm' && word[word.Length - 1] != 'g')
                            {
                                word = word.Remove(word.Length - 1);
                            }
                            Console.WriteLine(word);
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                    }
               
                    word = "";
                    index = 0;
                    continue;
                }
                word = word.Insert(index, Convert.ToString((char)letter));
                index++;
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