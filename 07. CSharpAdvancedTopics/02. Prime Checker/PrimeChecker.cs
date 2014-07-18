using System;

class PrimeChecker
{
    static bool isPrime (ulong UserNumber)
    {
        ulong devider = 2;
        ulong MaxDevider = Convert.ToUInt64(Math.Sqrt(UserNumber));

        if (UserNumber==0 || UserNumber==1)
        {
            return false;
        }

        for (ulong i = devider; i <= MaxDevider; i++)
        {
            if (UserNumber%i==0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        char choice;
        while (true)
        {
            Console.Write("Input number: ");
            ulong UserNumber = ulong.Parse(Console.ReadLine());

            Console.WriteLine(isPrime(UserNumber));

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