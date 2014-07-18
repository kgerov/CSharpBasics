using System;

class CirclePerimeterandArea
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input radius: ");
            double r = double.Parse(Console.ReadLine());
            double P = 2*3.1415*r;
            Console.WriteLine("The perimeter is: {0:F2}", P);
            Console.WriteLine("The area is: {0:F2}", (3.1415*r*r));

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}