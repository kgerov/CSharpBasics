using System;


class Program
{
    static void Main()
    {
        int a=0, b=-1;
       for(int i=0; i<10; i+=2)
       {
           a += 2;
           b -= 2;
           Console.WriteLine(a+", "+b);

       }
    }
}

