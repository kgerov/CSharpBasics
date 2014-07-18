using System;

class ZeroSubset
{
    static void Main()
    {
        char choice;
        while (true)
        {
            int[] arr = new int[5];
            int ZeroCounter = 0;
            bool flag = false;
            bool flag2 = false;


            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Input number {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] == 0)
                {
                    ZeroCounter++;
                }
            }

            //if all are zeros
            if (ZeroCounter == 5)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", arr[0], arr[1], arr[2], arr[3], arr[4]);
                flag = true;
                flag2 = true;
            }

            //check for 5 digits
            if (arr[0] + arr[1] + arr[2] + arr[3] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", arr[0], arr[1], arr[2], arr[3], arr[4]);
                flag = true;
            }

            //check for 4 digits 
            if (arr[0] + arr[1] + arr[2] + arr[3] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", arr[0], arr[1], arr[2], arr[3]);
                flag = true;
            }
            if (arr[4] + arr[1] + arr[2] + arr[3] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", arr[4], arr[1], arr[2], arr[3]);
                flag = true;
            }
            if (arr[0] + arr[4] + arr[2] + arr[3] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", arr[0], arr[4], arr[2], arr[3]);
                flag = true;
            }
            if (arr[0] + arr[1] + arr[4] + arr[3] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", arr[0], arr[1], arr[4], arr[3]);
                flag = true;
            }
            if (arr[0] + arr[1] + arr[2] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", arr[0], arr[1], arr[2], arr[4]);
                flag = true;
            }

            // check for 3 digits
            if (arr[0] + arr[1] + arr[2] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2}= 0", arr[0], arr[1], arr[2]);
                flag = true;
            }
            if (arr[0] + arr[1] + arr[3] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2}= 0", arr[0], arr[1], arr[3]);
                flag = true;
            }
            if (arr[0] + arr[1] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2}= 0", arr[0], arr[1], arr[4]);
                flag = true;
            }
            if (arr[0] + arr[2] + arr[3] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2}= 0", arr[0], arr[2], arr[3]);
                flag = true;
            }
            if (arr[0] + arr[2] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2}= 0", arr[0], arr[2], arr[4]);
                flag = true;
            }
            if (arr[0] + arr[3] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2}= 0", arr[0], arr[3], arr[4]);
                flag = true;
            }
            if (arr[1] + arr[2] + arr[3] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2}= 0", arr[1], arr[2], arr[3]);
                flag = true;
            }
            if (arr[1] + arr[2] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2}= 0", arr[1], arr[2], arr[4]);
                flag = true;
            }
            if (arr[1] + arr[3] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2}= 0", arr[1], arr[3], arr[4]);
                flag = true;
            }
            if (arr[2] + arr[3] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1} + {2}= 0", arr[2], arr[3], arr[4]);
                flag = true;
            }

            //check for 2 digits

            if (arr[0] + arr[1] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1}= 0", arr[0], arr[1]);
                flag = true;
            }
            if (arr[0] + arr[2] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1}= 0", arr[0], arr[2]);
                flag = true;
            }
            if (arr[0] + arr[3] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1}= 0", arr[0], arr[3]);
                flag = true;
            }
            if (arr[0] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1}= 0", arr[0], arr[4]);
                flag = true;
            }
            if (arr[1] + arr[2] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1}= 0", arr[1], arr[2]);
                flag = true;
            }
            if (arr[1] + arr[3] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1}= 0", arr[1], arr[3]);
                flag = true;
            }
            if (arr[1] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1}= 0", arr[1], arr[4]);
                flag = true;
            }
            if (arr[2] + arr[3] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1}= 0", arr[2], arr[3]);
                flag = true;
            }
            if (arr[2] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1}= 0", arr[2], arr[4]);
                flag = true;
            }
            if (arr[3] + arr[4] == 0 && flag2 == false)
            {
                Console.WriteLine("{0} + {1}= 0", arr[3], arr[4]);
                flag = true;
            }

            if (flag == false)
                Console.WriteLine("No zero subsets ):");

            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}