using System;

class FormattingNumbers
{
    static void Main()
    {
        char choice;
        while (true)
        {
            int a;
            do
            {
                Console.Write("Input a: ");
                a = int.Parse(Console.ReadLine());
            }while (a > 500 || a < 0);
            Console.Write("Input b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            float c = float.Parse(Console.ReadLine());

            string d = Convert.ToString(a, 2);
            char pad = '0';
            

            Console.WriteLine("|{0,-10:X} |" + d.PadLeft(10, pad) + "| {1,10:0.00}| {2,-10:0.000}| ", a, b, c);

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}