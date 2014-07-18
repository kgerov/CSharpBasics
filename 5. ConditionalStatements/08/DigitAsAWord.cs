using System;

class DigitAsAWord
{
    static void Main()
    {
        char choice;
        while (true)
        {

            Console.Write("Input digit: ");
            string input = Console.ReadLine();
            int a;
            if(int.TryParse(input, out a))
            {

            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

            switch(a)
            {
                case 0: Console.WriteLine("Zero");
                    break;
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                case 6: Console.WriteLine("Six");
                    break;
                case 7: Console.WriteLine("Seven");
                    break;
                case 8: Console.WriteLine("Eight");
                    break;
                case 9: Console.WriteLine("Nine");
                    break;
                default: Console.WriteLine("Invalid number");
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