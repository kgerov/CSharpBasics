using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size of side: ");
        int choice = int.Parse(Console.ReadLine());
        char c = '©';
        char s = ' ';
        int j;
        int counter = 1;
        for(int i=0; i<choice; i++)
        {
            if(i==0)
            {
                j = choice;
                while(j>1)
                {
                    Console.Write(s);
                    j--;
                }
                Console.WriteLine(c);
                continue;
            }

            if(i==choice-1)
            {
                j = i;
                while(j>0)
                {
                    Console.Write(c);
                    Console.Write(s);
                    j--;
                }
                Console.WriteLine(c);
                break;
            }

            j=choice-i-1;
            while(j>0)
            {
                Console.Write(s);
                j--;
            }

            Console.Write(c);
            j = counter;
            while(j>0)
            {
                Console.Write(s);
                j--;
            }
            counter += 2;
            Console.WriteLine(c);
        }
        Console.WriteLine();
    }
}


