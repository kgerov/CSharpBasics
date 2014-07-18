using System;

class BeerTime
{
    static void Main()
    {
        char choice;
        while (true)
        {
            string time;
            DateTime time2;
            string am = "AM";
            string pm = "PM";
            int a, b;
            bool flagA = false;
            bool flagB = false;
            DateTime am1 = DateTime.Parse("00:00");
            DateTime am2 = DateTime.Parse("03:00");
            DateTime pm1 = DateTime.Parse("01:00");
            DateTime pm2 = DateTime.Parse("11:59");


            do
            {
                Console.Write("Input time: ");
                time = Console.ReadLine();
                a = time.IndexOf(am);
                if (a >= 0)
                {
                    time = time.Remove(a, am.Length);
                    flagA = true;
                }

                b = time.IndexOf(pm);
                if(b>=0)
                {
                    time = time.Remove(b, pm.Length);
                    flagB = true;
                }

            } while (!DateTime.TryParse(time, out time2));

            int result1=DateTime.Compare(time2, am1);
            int result2=DateTime.Compare(time2, am2);
            int result3=DateTime.Compare(time2, pm1);
            int result4=DateTime.Compare(time2, pm2);

            if (flagA==true)
            {
                if(result1 >= 0 && result2 <0)
                {
                    Console.WriteLine("BEER TIME!");
                }
            }
            else if (flagB == true)
            {
                if (result3 >= 0 && result4 <= 0)
                {
                    Console.WriteLine("BEER TIME!");
                }
            }
            else 
            {
                Console.WriteLine("Not beer time ):");
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