using System;

    class Program
    {
        static void Main()
        {
            double n1, n2;
            bool flag=false;

            n1 = 5.3;
            n2 = 6.01;
            if((Math.Abs(n1-n2)<0.000001))
            {
                flag = true;
                Console.WriteLine("They are equal? {0}",flag);
            }
            else
            {
                Console.WriteLine("They are equal? {0}", flag);
            }

            n1 = 5.00000001;
            n2 = 5.00000003;
            flag = false;
            if ((Math.Abs(n1 - n2) < 0.000001))
            {
                flag = true;
                Console.WriteLine("They are equal? {0}", flag);
            }
            else
            {
                Console.WriteLine("They are equal? {0}", flag);
            }

            n1 = -0.0000007;
            n2 = 0.00000007;
            flag = false;
            if ((Math.Abs(n1 - n2) < 0.000001))
            {
                flag = true;
                Console.WriteLine("They are equal? {0}", flag);
            }
            else
            {
                Console.WriteLine("They are equal? {0}", flag);
            }

            n1 = -4.999999;
            n2 = -4.999998;
            flag = false;
            if ((Math.Abs(n1 - n2) < 0.000001))
            {
                flag = true;
                Console.WriteLine("They are equal? {0}", flag);
            }
            else
            {
                Console.WriteLine("They are equal? {0}", flag);
            }
           
        }
    }

