using System;

class SpiralMatrix
{
   static void PrintMatrix (int[,] matrix, int Size)
    {
        for (int i = 0; i < Size ; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Console.Write("{0, -5}", matrix[i,j]);
            }

            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine(new string('_', 15));
    }

    static void MicroCounterChange(ref int MicroCounter, ref int RowRight, ref int RowLeft, ref int RowFinal,
        ref int ColDown, ref int ColUp, ref int ColFinal)
   {
       switch (MicroCounter)
       {
           case 0: RowFinal = RowRight + 1;
                   RowRight++;
               break;
           case 1: ColFinal = ColDown - 1;
                   ColDown--;
               break;
           case 2: RowFinal = RowLeft - 1;
                   RowLeft--;
               break;
           case 3: ColFinal = ColUp + 1;
                   ColUp++;
               break;
           default: Console.WriteLine("Error");
               break;
       }
   }

    static void ChangeMatrix(ref int[,] matrix, int MicroCounter, ref int NumbersToFill, int RowFinal, int ColFinal, int StartPositon, int EndPosition, int Size)
    {
        switch (MicroCounter)
        {
            case 0: for (int i = StartPositon; i < (Size-EndPosition); i++)
                       {
                           matrix[RowFinal, i] = NumbersToFill;
                           NumbersToFill++;
                       }
                break;
            case 1: for (int i = StartPositon; i < Size - EndPosition; i++)
                {
                    matrix[i, ColFinal] = NumbersToFill;
                    NumbersToFill++;
                }
                break;
            case 2: for (int i = (Size-1) - StartPositon; i > EndPosition; i--)
                {
                    matrix[RowFinal, i] = NumbersToFill;
                    NumbersToFill++;
                }
                break;
            case 3: for (int i = Size - StartPositon; i >= EndPosition ; i--)
                {
                    matrix[i, ColFinal] = NumbersToFill;
                    NumbersToFill++;
                }
                break;
            default: Console.WriteLine("Error");
                break;
        }
    }

    static void PositionChange(ref int StartPosition, ref int EndPosition, int MicroCounter, int MacroCounter)
    {
        if(MacroCounter==1)
        {
            StartPosition = 1;
        }
        else if ((MacroCounter-1) % 4 == 0 && MacroCounter>2)
        {
                StartPosition++;
        }

        if(MacroCounter > 2 && (MacroCounter-3)%4==0)
        {
            EndPosition++;
        }
        
    }

    static void Main()
    {   
        char choice;
        while (true)
        { 
            //input and variables needed
            Console.Write("Size of spiral: ");
            int Size = int.Parse(Console.ReadLine());

            int RowRight = -1, RowLeft = Size;
            int RowFinal = RowRight;
            int ColDown = Size, ColUp = -1;
            int ColFinal = ColDown;

            int StartPosition = 0;
            int EndPosition = 0;

            int MicroCounter = 0; //It takes care of all the specific cases. It counts until 4
            int MacroCounter = 0; //Counts all the moves that are made

            int NumbersToFill = 1;

            int[,] matrix = new int[Size, Size];
 
            //Filling of matrix
            while (NumbersToFill<=Size*Size)
            {
                MicroCounterChange(ref MicroCounter, ref RowRight, ref RowLeft, ref RowFinal, ref ColDown, ref ColUp, ref ColFinal);
                PositionChange(ref StartPosition, ref EndPosition, MicroCounter, MacroCounter);

                ChangeMatrix(ref matrix, MicroCounter, ref NumbersToFill, RowFinal, ColFinal, StartPosition, EndPosition, Size);

                MicroCounter++; MacroCounter++;
                if (MicroCounter > 3)
                    MicroCounter = 0;          
            }

            //Printing the matrix to the console
            PrintMatrix(matrix, Size);


            Console.Write("Try again? (Y/N): ");
            choice = char.Parse(Console.ReadLine());
            if (choice != 'y' && choice != 'Y')
            {
                break;
            }

        }
    }
}