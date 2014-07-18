using System;
class Program
{
    static void Main()
    {
        bool flag;
        Console.Write("Input int: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Which bit you want to check if it is 1: ");
        int p = int.Parse(Console.ReadLine());

        int NumRightP = num >> p;
        int check = NumRightP & 1;

        if (check == 1)
        {
            flag = true;
        }
        else
        {
            flag = false;
        }

        Console.WriteLine(flag);


    }
}
