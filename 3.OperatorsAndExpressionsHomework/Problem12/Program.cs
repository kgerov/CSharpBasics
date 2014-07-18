using System;
class Program
{
    static void Main()
    {
            Console.Write("Input int: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("What bit do you want: ");
            int p = int.Parse(Console.ReadLine());

            int PRightNum = num >> p;
            int result = PRightNum & 1;
            Console.WriteLine("The result is: " + result);   
    }
}
