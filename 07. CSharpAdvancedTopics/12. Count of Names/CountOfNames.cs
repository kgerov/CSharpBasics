using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{ 
    //There is a mistake in the second example. I used the same code from the last problem.
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input names: ");
            List<string> letters = Console.ReadLine().Split().ToList();
            Dictionary<string, string> result = new Dictionary<string, string>();

            for (int i = 0; i < letters.Count; i++)
            {
                int counter = 1;

                for (int j = i + 1; j < letters.Count; j++)
                {
                    if (letters[i] == letters[j])
                    {
                        counter++;
                    }
                }
                if (!result.ContainsKey(letters[i]))
                {
                    result[letters[i]] = Convert.ToString(counter);
                }

            }

            List<KeyValuePair<string, string>> sortedList = result.ToList();

            sortedList.Sort((firstPair, nextPair) =>
            {
                return firstPair.Key.CompareTo(nextPair.Key);
            }
            );

            foreach (var letter in sortedList)
            {
                Console.WriteLine("{0} -> {1}", letter.Key, letter.Value);
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