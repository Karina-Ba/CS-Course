using System;



namespace B20_Ex01_2
{
    public class Program //Use stringbuilder
    {
        public static char s_Star = '*';
        public static int s_RowLength = 5;
        public static void Main()
        {
            PrintSandClock(s_RowLength);
        }
        public static void PrintSandClock(int i_RowLength)
        {
            //Call recursive function
            if (i_RowLength % 2 == 1)
            {
                RecursivePrintSandClock(i_RowLength, i_RowLength);
            }

            else
            {
                RecursivePrintSandClock(i_RowLength + 1, i_RowLength + 1);
            }
        }

        public static void RecursivePrintSandClock(int i_CurrentRowLength, int i_MaximumRowLength)
        {
            int numOfSpaces = (i_MaximumRowLength - i_CurrentRowLength) / 2;
            printToConsole(numOfSpaces, " ");
            printToConsole(i_CurrentRowLength, s_Star.ToString());
            printToConsole(1, Environment.NewLine);

            if (i_CurrentRowLength <= 1)
            {
                return;
            }

            RecursivePrintSandClock(i_CurrentRowLength - 2, i_MaximumRowLength);
            printToConsole(numOfSpaces, " ");
            printToConsole(i_CurrentRowLength, s_Star.ToString());
            printToConsole(1, Environment.NewLine);
        }

        private static void printToConsole(int i_Amount, string i_StringToPrint)
        {
            for (int i = 0; i < i_Amount; ++i)
            {
                Console.Write(i_StringToPrint);
            }
        }
    }

}