using System;
using System.Collections.Generic;
using System.Text;

namespace B20_Ex01_5
{
    class Program
    {
        //-----------------------------------------------------------------------------------------------------------------------//
        public static void Main()
        {
            programInitiation();
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        private static void programInitiation()
        {
            string userInputString;
            bool isLegalInput = false;
            System.Console.WriteLine("Please enter a string");
            userInputString = System.Console.ReadLine();
            isLegalInput = checkUserInputString(userInputString);
            while (isLegalInput == false)
            {
                System.Console.WriteLine("Invalid input, please enter another:");
                userInputString = System.Console.ReadLine();
                isLegalInput = checkUserInputString(userInputString);
            }
            printMaximumDigitInTheNumber(userInputString);
            printMinimumDigitInTheNumber(userInputString);
            countDigitsDevidedByThreeNoRemain(userInputString);
            countDigitsGreaterThanTheFirstDigit(userInputString);
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        private static bool checkUserInputString(string i_UserInputString)
        {
            int stringNumberRepresentation;
            bool isLegalInput = true;
            if (i_UserInputString.Length != 9)
            {
                isLegalInput =false;
            }
            if(!(int.TryParse(i_UserInputString,out stringNumberRepresentation)))
            {
                isLegalInput = false;
            }
            return isLegalInput;
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        private static void printMaximumDigitInTheNumber(string i_Number)
        {
            double maximumDigit = char.GetNumericValue(i_Number[0]);
            double currentDigitNumberRepresentation;
            foreach (char digitToCheck in i_Number)
            {
                currentDigitNumberRepresentation = char.GetNumericValue(digitToCheck);
                if (currentDigitNumberRepresentation >= maximumDigit)
                {
                    maximumDigit = currentDigitNumberRepresentation;
                }
            }
            System.Console.WriteLine(string.Format("The maximum digit in the string is: {0}", maximumDigit.ToString()));
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        private static void printMinimumDigitInTheNumber(string i_Number)
        {
            double minimumDigit = char.GetNumericValue(i_Number[0]);
            double currentDigitNumberRepresentation;
            foreach (char digitToCheck in i_Number)
            {
                currentDigitNumberRepresentation = char.GetNumericValue(digitToCheck);
                if (currentDigitNumberRepresentation <= minimumDigit)
                {
                    minimumDigit = currentDigitNumberRepresentation;
                }
            }
            System.Console.WriteLine(string.Format("The minimum digit in the string is: {0}", minimumDigit.ToString()));

        }
        //-----------------------------------------------------------------------------------------------------------------------//
        private static void countDigitsDevidedByThreeNoRemain(string i_Number)
        {
            int numOfDigitsDevidedByThreeWithoutRemaim = 0;
            double currentDigitNumberRepresentation;
            foreach (char digitToCheck in i_Number)
            {
                currentDigitNumberRepresentation = char.GetNumericValue(digitToCheck);
                if (currentDigitNumberRepresentation % 3 == 0)
                {
                    numOfDigitsDevidedByThreeWithoutRemaim++;
                }
            }
            System.Console.WriteLine(string.Format("The number of digits devided by 3 without a remain is: {0}", numOfDigitsDevidedByThreeWithoutRemaim.ToString()));
        }
        //-----------------------------------------------------------------------------------------------------------------------//
        private static void countDigitsGreaterThanTheFirstDigit(string i_Number)
        {
            int numberOfDigitsGreaterThanTheFirstDigit = 0;
            double firstDigit = char.GetNumericValue(i_Number[i_Number.Length - 1]);
            double currentDigitNumberRepresentation;
            foreach (char digitToCheck in i_Number)
            {
                currentDigitNumberRepresentation = char.GetNumericValue(digitToCheck);
                if (currentDigitNumberRepresentation > firstDigit)
                {
                    numberOfDigitsGreaterThanTheFirstDigit++;
                }
            }
            System.Console.WriteLine(string.Format("There are {0} digits greater than the first digit", numberOfDigitsGreaterThanTheFirstDigit));
        }
        //-----------------------------------------------------------------------------------------------------------------------//
    }
}
