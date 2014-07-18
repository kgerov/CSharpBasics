using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Input number: ");
            uint num = uint.Parse(Console.ReadLine());
            uint MaskResult = num;
            uint MaskFinal = num;
            int p = 3;
            int p2 = 24;

            uint num1, num2, NumRightP, bit, NumRightP2, bit2, BitMask, BitMask2;

            for (int i = 0; i < 3; i++)
            {
                num1 = num;
                num2 = num;


                NumRightP = num1 >> p;
                bit = NumRightP & 1;

                NumRightP2 = num2 >> p2;
                bit2 = NumRightP2 & 1;


                if (bit == 0)
                {
                    bit = 1;
                    BitMask = ~(bit << p2);
                    MaskResult = BitMask & MaskResult;
                }
                else
                {
                    BitMask = bit << p2;
                    MaskResult = BitMask | MaskResult;
                }

                if (bit2 == 0)
                {
                    bit2 = 1;
                    BitMask2 = ~(bit2 << p);
                    MaskResult = BitMask2 & MaskResult;
                }
                else
                {
                    BitMask = bit2 << p;
                    MaskResult = BitMask | MaskResult;
                }

                p++;
                p2++;

            }

            Console.WriteLine("Your new number is: " + MaskResult);

        }

    }
}
