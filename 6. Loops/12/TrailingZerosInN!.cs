using System;
using System.Numerics;
class TrailingZerosInN
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input number: ");
            ulong a = ulong.Parse(Console.ReadLine());

            ////Using a string 

            //ulong factorial = 1;
            //uint ZeroCounter = 0;

            //while(a>0)
            //{
            //    factorial *= a;
            //    a--;
            //}

            //string num = Convert.ToString(factorial);

            //for (int i = num.Length-1; i > 0; i--)
            //{
            //    if (num[i] != '0')
            //        break;

            //    if (num[i] == '0')
            //        ZeroCounter++;
            //}

            //Console.WriteLine("The number of zeros is: " + ZeroCounter);

            ////Using an algorithm

            int power = 1;
            int zeros = 0;

            while(a>Math.Pow(5, power))
            {
                zeros+=(int)(a/(Math.Pow(5, power)));
                power++;
            }

            Console.WriteLine("The number of zeros is: " + zeros);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}