using System;

class Program
{
    static void Main()
    {
        int a;
        bool flag = false;
        string spas =new String ('_', 30);
        
        while (flag == false)
        {
            Console.WriteLine("Write a number");
            a=int.Parse(Console.ReadLine());
            ConsoleKeyInfo cki;
            if (a % 2 == 0)
                Console.WriteLine("You typed and even number!");
            else
                Console.WriteLine("You wrote and odd number!");

            Console.WriteLine("Press any key but Esc to continue");
            cki = Console.ReadKey();
            Console.WriteLine();
            if(cki.Key == ConsoleKey.Escape)
            {
                flag = true;
            }
            Console.WriteLine(spas);
            Console.WriteLine();
        }
    }
}

