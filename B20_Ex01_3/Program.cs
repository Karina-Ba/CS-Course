using System;

namespace B20_Ex01_3
{
    public class Program
    {
        //-----------------------------------------------------------------------------------------------------------------------//
        public static void Main()
        {
            InitProgram();
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        public static void InitProgram()
        {
            int heightOfSandClock = getSandClockHeight();
            Console.WriteLine("Here is your chosen sand clock:");
            B20_Ex01_2.Program.PrintSandClock(heightOfSandClock);
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        private static int getSandClockHeight()
        {
            Console.WriteLine("Please enter the height you want for the sand clock:");
            string heightOfSandClockStr = Console.ReadLine();
            int heightOfSandClockInt;
            bool v_heightStringToInt = int.TryParse(heightOfSandClockStr, out heightOfSandClockInt); ;

            while (!v_heightStringToInt || heightOfSandClockInt <= 0)
            {
                Console.WriteLine(
@"Unable to create sand clock with that input.
Please enter a valid positive number for the height of the sand clock:");
                heightOfSandClockStr = Console.ReadLine();
                v_heightStringToInt = int.TryParse(heightOfSandClockStr, out heightOfSandClockInt);
            }

            return heightOfSandClockInt;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
    }
}