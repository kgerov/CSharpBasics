using System;

class Point
{
    public int x { get; set; }
    public int y { get; set; }
}

class Polygon
{
    static void Main()
    {
        char choice;
        while (true)
        {


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