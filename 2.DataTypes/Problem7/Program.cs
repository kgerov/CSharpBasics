using System;

class Program
{
    static void Main()
    {
        string s1 = "Hello";
        string s2 = "World";
        object o1 = s1 + " " + s2;
        string s3 = (string)o1;
        Console.WriteLine(s3);


    }
}


