using System;

class MultiplicationSign
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            double c = double.Parse(Console.ReadLine());

            int counter = 0;

            if (a < 0)
                counter++;
            if (b < 0)
                counter++;
            if (c < 0)
                counter++;

            if(a==0 || b==0 || c==0)
                Console.WriteLine(0);
            else if(counter%2==0)
                Console.WriteLine("+");
            else
                Console.WriteLine("-");

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}