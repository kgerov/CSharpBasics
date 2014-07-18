using System;


    class Program
    {
        static void Main()
        {
            int? a=null;
            double? b=null;
            Console.WriteLine("A special variable: {0}", a);
            Console.WriteLine("A special variable again: {0}", b);
            a+=5;
            b+=null;
            Console.WriteLine("An even more special variable: {0}", a);
            Console.WriteLine("damnn those special variables again: {0}", b);

        }
    }

