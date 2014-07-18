using System;

class Program
{
    static void Main()
    {
            bool flag = false;
            Console.Write("Enter x: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = Double.Parse(Console.ReadLine());

            if (Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2)) <=2)
                flag = true;

            if (flag == true)
                Console.WriteLine("The point is in the circle!");
            else
                Console.WriteLine("The point is out of the circle ):");
 
    }
}

