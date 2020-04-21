using System;

namespace B20_Ex01_1
{
    public class Program
    {
        public static void Main()
        {
            InitProgram();
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        public static void InitProgram()
        {
            string userInputString;
            double stringNumberRepresentation;
            float averageNumOfOnesInStrings = 0;
            float averageNumOfZerosInStrings = 0;
            int amountOfPowerTwoNumbers = 0;
            double maxNumber = 0, minNumber = 512;
            int amountOfNumbersThatAreARisingSeries = 0;
            float currentAmountOfOnes = 0;
            for(int i = 0; i < 3; ++i)
            {
                userInputString = getUserInput();
                stringNumberRepresentation = printNumberRepresentation(userInputString);

                if (stringNumberRepresentation >= maxNumber)
                {
                    maxNumber = stringNumberRepresentation;
                }
                if(stringNumberRepresentation <= minNumber)
                {
                    minNumber = stringNumberRepresentation;     
                }

                currentAmountOfOnes = getNumOfOnes(userInputString);
                averageNumOfOnesInStrings += currentAmountOfOnes;

                if (currentAmountOfOnes == 1) 
                {
                    amountOfPowerTwoNumbers++;
                }
                if (isARisingSeries((int)stringNumberRepresentation))
                {
                    amountOfNumbersThatAreARisingSeries++;
                }
            }
            averageNumOfZerosInStrings = 27 - averageNumOfOnesInStrings;
            averageNumOfOnesInStrings /= 3;
            averageNumOfZerosInStrings /= 3;
            Console.WriteLine(string.Format(
@"The average number of ones in the three sets is: {0} 
The average number of zeros in the three sets is: {1}
The amount of numbers that are power of 2 are: {2}
The amount of numbers that are a rising series are: {3}
The biggest number is: {4}
The smallest number is: {5} ",
            averageNumOfOnesInStrings.ToString(),
            averageNumOfZerosInStrings.ToString(),
            amountOfPowerTwoNumbers.ToString() ,
            amountOfNumbersThatAreARisingSeries.ToString(),
            maxNumber.ToString(), minNumber.ToString()));
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        //get the user input string, and check for good input
        private static string getUserInput()
        {
            string input;
            bool isBadInput = true;
            int countAmountOfNumbersInBinarySet = 0;
            input = System.Console.ReadLine();
            while (isBadInput)
            {
                foreach (char c in input)
                {
                    if (c != '1' && c != '0')
                    {
                        System.Console.WriteLine("Invalid input, please enter another:\n");
                        input = System.Console.ReadLine();
                        isBadInput = true;
                        break;
                    }
                    isBadInput = false;
                    countAmountOfNumbersInBinarySet++;
                }
                if (countAmountOfNumbersInBinarySet != 9)
                {
                    System.Console.WriteLine("The series is too long, please enter another:\n");
                    input = System.Console.ReadLine();
                    isBadInput = true;
                }
            }
            return input;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        //Convert binary number to decimal number
        private static double printNumberRepresentation(string i_StringToConvert)
        {
            
            double stringNum = 0;
            double exponent = 0;
            for (int index = i_StringToConvert.Length - 1; index >= 0; index--) 
            {
                if (char.Equals(i_StringToConvert[index],'1'))
                {
                    stringNum += System.Math.Pow(2.0, exponent);
                }
                exponent++;
            }
            Console.WriteLine(stringNum.ToString());
            return stringNum;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        //return the number on ones in the string
        private static float getNumOfOnes(string io_stringToCount)
        {
            float io_numberOfOnes = 0;
            foreach (char c in io_stringToCount)
            {
                if (c == '1')
                {
                    io_numberOfOnes++;
                }
            }
            return io_numberOfOnes;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        private static bool isARisingSeries(int io_numToCheckForRisingSeries)
        {
            bool isRisingSeries = true;
            int currentDigit = 0;
            int previousDigit = io_numToCheckForRisingSeries % 10;
            io_numToCheckForRisingSeries = io_numToCheckForRisingSeries / 10;
            while (io_numToCheckForRisingSeries > 0 &&isRisingSeries )
            {
                currentDigit = io_numToCheckForRisingSeries % 10;
                if (currentDigit > previousDigit)
                {
                    isRisingSeries = false;
                }
                previousDigit = currentDigit;
                io_numToCheckForRisingSeries = io_numToCheckForRisingSeries / 10;

            }
            return isRisingSeries;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
    }
}