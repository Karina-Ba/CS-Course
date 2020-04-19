using System;

namespace System
{
    class Program
    {
        public static string s_Star = "*";
        public static int s_NumOfRows = 6;
        public static int s_RowLength = 5;


        static void Main()
        {
            PrintSandClock();
        }

        public static void PrintSandClock()
        {
            //Call recursive function
            RecursivePrintSandClock(s_RowLength);
        }

        public static void RecursivePrintSandClock(int i_RowLength)
        {
            int numOfSpaces = (s_NumOfRows - i_RowLength) / 2;
            PrintToConsole(numOfSpaces, " ");
            PrintToConsole(i_RowLength, s_Star);
            if (i_RowLength == 1)
            {
                return;
            }
            PrintToConsole(1, Environment.NewLine);
            RecursivePrintSandClock(i_RowLength - 2);
            PrintToConsole(numOfSpaces, " ");
            PrintToConsole(i_RowLength, s_Star);
            PrintToConsole(1, Environment.NewLine);
        }

        public static void PrintToConsole(int i_Amount, string i_CharToPrint)
        {
            for (int i = 0; i < i_Amount; ++i)
            {
                Console.Write(i_CharToPrint);
            }
        }
    }
}
