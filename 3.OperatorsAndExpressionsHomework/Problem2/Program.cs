using System;

class Program
{
    static void Main()
    {
        int a;
        bool flag = false;

        while(flag==false)
        {
            Console.Write("Enter your weight: ");
            a = int.Parse(Console.ReadLine());
            ConsoleKeyInfo cki;

            Console.WriteLine(a*0.17);

            cki = Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("WANNA CONTINUE??");
            if(cki.Key==ConsoleKey.Escape)
            {
                flag=true;
            }
            Console.WriteLine();

        }
    }
}

