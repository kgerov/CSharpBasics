using System;

class QuadraticEquation
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            double c = double.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            double x1=0, x2=-1;
            bool flag = false;


            if(D>=0)
            {
                x1 = (-1 * b + Math.Sqrt(D)) / (2 * a);
                x2 = (-1 * b - Math.Sqrt(D)) / (2 * a);

            }
            else
            {
                flag = true;
            }

            if(flag==true)
            {
                Console.WriteLine("No solution");
            }
            else if(x1==x2)
            {
                Console.WriteLine("Two identical roots which are: " + x1);
            }
            else
            {
                Console.WriteLine("Root 1: {0}, Root 2: {1}", x1, x2);
            }


            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}