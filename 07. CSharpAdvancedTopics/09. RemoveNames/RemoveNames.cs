using System;
using System.Linq;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("First sequence: ");
            List<string> names = Console.ReadLine().Split().ToList();
            Console.Write("Second sequence: ");
            List<string> RemoveNames = Console.ReadLine().Split().ToList();

            for (int i = 0; i < RemoveNames.Count; i++)
            {
                string RemoveNow = RemoveNames[i];

                for (int j = 0; j < names.Count; j++)
                {
                    if (RemoveNow == names[j])
                    {
                        names.RemoveAt(j);
                        j--;
                    }
                }
            }

            foreach (var name in names)
            {
                Console.Write(name + " ");
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