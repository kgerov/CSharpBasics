using System;

class AverageLoadCalculator
{
    static void Main()
    {
        char choice;
        while (true)
        {
            //I'm not very sure how should I input the text. If it is the whole text at once then the problem would be solved similar to problem 15. 


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