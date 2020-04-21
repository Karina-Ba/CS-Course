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
            float averageNumOfOnesInStrings = 0;
            float averageNumOfZerosInStrings = 0;
            int amountOfPowerTwoNumbers = 0;
            double maxNumber = 0, minNumber = 512;
            int amountOfNumbersThatAreARisingSeries = 0;
            double[] numbersArr = { 0, 0, 0 };
            float currentAmountOfOnes = 0;
            Console.WriteLine("Please enter 3 binary strings with 9 characters each:");
            for(int i = 0; i < 3; ++i)
            {
                userInputString = getUserInput();
                numbersArr[i] = getNumberRepresentation(userInputString);
                if (numbersArr[i] >= maxNumber)
                {
                    maxNumber = numbersArr[i];
                }
                if(numbersArr[i] <= minNumber)
                {
                    minNumber = numbersArr[i];     
                }

                currentAmountOfOnes = getNumOfOnes(userInputString);
                averageNumOfOnesInStrings += currentAmountOfOnes;

                if (currentAmountOfOnes == 1) 
                {
                    amountOfPowerTwoNumbers++;
                }
                if (isARisingSeries((int)numbersArr[i]))
                {
                    amountOfNumbersThatAreARisingSeries++;
                }
            }
            Console.WriteLine("The decimal number representations of the 3 binary string are: ");
            for(int i = 0; i < 3; ++i)
            {
                Console.WriteLine("{0}", numbersArr[i]);
            }
            averageNumOfZerosInStrings = 27 - averageNumOfOnesInStrings;
            averageNumOfOnesInStrings /= 3;
            averageNumOfZerosInStrings /= 3;
            Console.WriteLine(
@"The average number of ones in the three sets is: {0} 
The average number of zeros in the three sets is: {1}
The amount of numbers that are power of 2 are: {2}
The amount of numbers that are a rising series are: {3}
The biggest number is: {4}
The smallest number is: {5} ",
            averageNumOfOnesInStrings,
            averageNumOfZerosInStrings,
            amountOfPowerTwoNumbers ,
            amountOfNumbersThatAreARisingSeries,
            maxNumber, minNumber);
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        //get the user input string, and check for good input
        private static string getUserInput()
        {
            string stringFromInput = Console.ReadLine();
            bool isLegalInput = false;

            while (isLegalInput == false)
            {
                if (stringFromInput.Length != 9)
                {
                    isLegalInput = false;
                    Console.WriteLine("The series is not 9 characters long, please enter another string:");
                    stringFromInput = Console.ReadLine();
                }
                else
                {
                    foreach(char c in stringFromInput)
                    {
                        if(c != '1' && c!= '0')
                        {
                            isLegalInput = false;
                            Console.WriteLine("Invlid input, please enter another string in binary only:");
                            stringFromInput = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            isLegalInput = true;
                        }
                    }
                }
            }
            return stringFromInput;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        //Convert binary number to decimal number
        private static double getNumberRepresentation(string i_StringToConvert)
        {
            double stringNum = 0;
            double exponent = 0;
            for (int index = i_StringToConvert.Length - 1; index >= 0; index--) 
            {
                if (char.Equals(i_StringToConvert[index],'1'))
                {
                    stringNum += Math.Pow(2.0, exponent);
                }
                exponent++;
            }
            return stringNum;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        //return the number on ones in the string
        private static float getNumOfOnes(string i_stringToCount)
        {
            float numberOfOnes = 0;
            foreach (char c in i_stringToCount)
            {
                if (c == '1')
                {
                    numberOfOnes++;
                }
            }
            return numberOfOnes;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        private static bool isARisingSeries(int i_numToCheckForRisingSeries)
        {
            bool isRisingSeries = true;
            int currentDigit = 0;
            int previousDigit = i_numToCheckForRisingSeries % 10;
            i_numToCheckForRisingSeries = i_numToCheckForRisingSeries / 10;
            while (i_numToCheckForRisingSeries > 0 &&isRisingSeries )
            {
                currentDigit = i_numToCheckForRisingSeries % 10;
                if (currentDigit > previousDigit)
                {
                    isRisingSeries = false;
                }
                previousDigit = currentDigit;
                i_numToCheckForRisingSeries = i_numToCheckForRisingSeries / 10;

            }
            return isRisingSeries;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
    }
}