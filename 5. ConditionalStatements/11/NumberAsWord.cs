using System;

class Program
{
    static string Edinici(int x)
    {
        switch (x)
        {
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            case 0: return "Zero";
            default: return "Error";
        }
    }

    static string SpecialDesetici(int x)
    {
        switch (x)
        {
            case 1: return "Eleven";
            case 2: return "Twelve";
            case 3: return "Thirteen";
            case 4: return "Fourteen";
            case 5: return "Fifteen";
            case 6: return "Sixteen";
            case 7: return "Seventeen";
            case 8: return "Eighteen";
            case 9: return "Nineteen";
            case 0: return "Zero";
            default: return "Error";
        }
    }
    static string Desetici(int x)
    {
        switch (x)
        {
            case 1: return "Ten";
            case 2: return "Twenty";
            case 3: return "Thirty";
            case 4: return "Fourty";
            case 5: return "Fifty";
            case 6: return "Sixty";
            case 7: return "Seventy";
            case 8: return "Eighty";
            case 9: return "Ninety";
            default: return "Error";
        }
    }
    static void Main()
    {   
        char choice;
        while (true)
        {
            Console.Write("Write a number: ");
            int x = int.Parse(Console.ReadLine());
            int a = x % 10;
            int b = (x - a) / 10 % 10;
            int c = (x - 10 * b - a) / 100 % 10;

            if(b==0 && c == 0)
            {
                Console.WriteLine(Program.Edinici(a));
            }
            else if(c==0)
            {
                if(b==1 && a!=0)
                {
                    Console.WriteLine(SpecialDesetici(a));
                }
                else if(a==0)
                {
                    Console.WriteLine(Desetici(b));
                }
                else 
                {
                    Console.WriteLine("{0} {1}", Desetici(b), Edinici(a));
                }
            }
            else if(c!=0)
            {
                Console.Write(Edinici(c) + " hundred");
                if (b == 0 && a != 0)
                {
                    Console.WriteLine(" and " + Program.Edinici(a));
                }
                else if(b!=0)
                {
                    if (b == 1 && a != 0)
                    {
                        Console.WriteLine(" and " + SpecialDesetici(a));
                    }
                    else if (a == 0)
                    {
                        Console.WriteLine(" and " + Desetici(b));
                    }
                    else
                    {
                        Console.WriteLine(" and {0} {1}", Desetici(b), Edinici(a));
                    }
                }
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