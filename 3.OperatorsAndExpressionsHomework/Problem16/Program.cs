using System;
class Program
{
    static void Main()
    {
            Console.Write("Input number: ");
            uint num = uint.Parse(Console.ReadLine());

            uint MaskResult = num;
            uint MaskFinal = num;
            uint num1, num2, NumRightP, bit, NumRightP2, bit2, BitMask, BitMask2;
            bool Overlap = false;
            bool OutOfRange = false;
            int p, p2, k;
            do
            {
                Console.Write("Input p: ");
                p = int.Parse(Console.ReadLine());
                Console.Write("Input p2: ");
                p2 = int.Parse(Console.ReadLine()); //I use p2 instead of q
                Console.Write("Input k: ");
                k = int.Parse(Console.ReadLine());
            } while ((p < 0 || p >32) || (p2 < 0 || p2>32) || k < 0);

            if(Math.Min(p,p2)+k>Math.Max(p,p2))
            {
                Overlap = true;
            }

            if(Math.Max(p,p2)+k>32)
            {
                OutOfRange = true;
            }

            for (int i = 0; i < k; i++)
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

            while (true)
            {
                if (Overlap == true)
                {
                    Console.WriteLine("Overlap!");
                    break;
                }

                if (OutOfRange == true)
                {
                    Console.WriteLine("Out of Range!");
                    break;
                }

                if (Overlap == true && OutOfRange == true)
                {
                    Console.WriteLine("Overlap and Out Of Range!");
                    break;
                }
                else
                {
                    Console.WriteLine("Your new number is: " + MaskResult);
                    break;
                }
            }
        

    }
}
