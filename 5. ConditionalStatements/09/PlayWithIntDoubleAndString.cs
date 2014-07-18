using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        char choice;
        while (true)
        {
            Console.WriteLine("1. Int");
            Console.WriteLine("2. Double");
            Console.WriteLine("3. String");
            Console.Write("Choose type: ");
            int n = int.Parse(Console.ReadLine());

            switch(n)
            {
                case 1:Console.Write("Input int: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + (b+1 ));
                    break;

                case 2: Console.Write("Input double:" );
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + (a+1 ));
                    break;

                case 3: Console.Write("Input string:" );
                string c = Console.ReadLine();
                Console.WriteLine("Result: " + c + "*" );
                    break;
                default: Console.WriteLine("Choose more wisely...");
                    break;
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