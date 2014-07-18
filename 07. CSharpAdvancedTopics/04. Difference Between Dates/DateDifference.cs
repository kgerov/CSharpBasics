using System;

class DateDifference
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input First date: ");
            DateTime DateOne = DateTime.Parse(Console.ReadLine());
            Console.Write("Input First date: ");
            DateTime DateTwo = DateTime.Parse(Console.ReadLine());

            Console.WriteLine((DateTwo - DateOne).TotalDays);

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