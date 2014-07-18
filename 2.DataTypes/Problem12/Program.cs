using System;


class Program
{
    static void Main()
    {
        string FName = "Kolio";
        string MName = "Kokainov";
        string LName = "Hercata";
        ulong balance = 18446744073709551615;
        string Bank = "Bulbank";
        long card1 = 83061125073478;
        long card2 = 345698760912345;
        long card3 = 123456780987654;
        string IBAN = "SWAG763824793284BG";

        Console.WriteLine("First, Middle and Last name are: {0} {1} {2}", FName, MName, LName);
        Console.WriteLine("The balance in bank {0} is {1}", Bank, balance);
        Console.WriteLine("The number of your 3 credi cards are: {0}, {1}, {2}", card1, card2, card3);
        Console.WriteLine("Your IBAN is {0}", IBAN);
    }
}
