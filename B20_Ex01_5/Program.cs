using System;
using System.Collections.Generic;
using System.Text;

namespace B20_Ex01_5
{
    class Program
    {
        static void Main()
        {
            ProgramInitiation();
        }

        static void ProgramInitiation()
        {
            string i_UserInputString;
            bool i_IsLegalInput = false;
            System.Console.WriteLine("Please enter a string");
            i_UserInputString = System.Console.ReadLine();
            i_IsLegalInput = CheckUserInputString(i_UserInputString);
            while (i_IsLegalInput == false)
            {
                System.Console.WriteLine("Invalid input, please enter another:");
                i_UserInputString = System.Console.ReadLine();
                i_IsLegalInput = CheckUserInputString(i_UserInputString);
            }
            PrintMaximumDigitInTheNUMBER(i_UserInputString);
            PrintMinimumDigitInTheNumber(i_UserInputString);
            CountDigitsDevidedByThreeNoRemain(i_UserInputString);
            CountDigitsGreaterThanTheFirstDigit(i_UserInputString);
        }

        static bool CheckUserInputString(string i_UserInputString)
        {
            if (i_UserInputString.Length != 9)
            {
                return false;
            }
            foreach (char i_CurrentCharToCheck in i_UserInputString)
            {
                if (!char.IsDigit(i_CurrentCharToCheck))
                {
                    return false;
                }
            }
            return true;
        }

        static void PrintMaximumDigitInTheNUMBER(string i_Number)
        {
            double i_MaximumDigit = char.GetNumericValue(i_Number[0]);
            double i_CurrentDigitNumberRepresentation;
            foreach (char i_DigitToCheck in i_Number)
            {
                i_CurrentDigitNumberRepresentation = char.GetNumericValue(i_DigitToCheck);
                if (i_CurrentDigitNumberRepresentation >= i_MaximumDigit)
                {
                    i_MaximumDigit = i_CurrentDigitNumberRepresentation;
                }
            }
            System.Console.WriteLine(string.Format("The maximum digit in the string is: ", i_MaximumDigit.ToString()));
        }

        static void PrintMinimumDigitInTheNumber(string i_Number)
        {
            double i_MinimumDigit = char.GetNumericValue(i_Number[0]);
            double i_CurrentDigitNumberRepresentation;
            foreach (char i_DigitToCheck in i_Number)
            {
                i_CurrentDigitNumberRepresentation = char.GetNumericValue(i_DigitToCheck);
                if (i_CurrentDigitNumberRepresentation <= i_MinimumDigit)
                {
                    i_MinimumDigit = i_CurrentDigitNumberRepresentation;
                }
            }
            System.Console.WriteLine(string.Format("The minimum digit in the string is: ", i_MinimumDigit.ToString()));

        }

        static void CountDigitsDevidedByThreeNoRemain(string i_Number)
        {
            int i_NumOfDigitsDevidedByThreeWithoutRemaim = 0;
            double i_CurrentDigitNumberRepresentation;
            foreach (char i_DigitToCheck in i_Number)
            {
                i_CurrentDigitNumberRepresentation = char.GetNumericValue(i_DigitToCheck);
                if (i_CurrentDigitNumberRepresentation % 3 == 0)
                {
                    i_NumOfDigitsDevidedByThreeWithoutRemaim++;
                }
            }
            System.Console.WriteLine(string.Format("The number of digits devided by 3 without a remain is:{0}", i_NumOfDigitsDevidedByThreeWithoutRemaim.ToString()));
        }

        static void CountDigitsGreaterThanTheFirstDigit(string i_Number)
        {
            int i_NumberOfDigitsGreaterThanTheFirstDigit = 0;
            double i_FirstDigit = char.GetNumericValue(i_Number[i_Number.Length - 1]);
            double i_CurrentDigitNumberRepresentation;
            foreach (char i_DigitToCheck in i_Number)
            {
                i_CurrentDigitNumberRepresentation = char.GetNumericValue(i_DigitToCheck);
                if (i_CurrentDigitNumberRepresentation > i_FirstDigit)
                {
                    i_NumberOfDigitsGreaterThanTheFirstDigit++;
                }
            }
            System.Console.WriteLine(string.Format("There are {0} digits greater than the first digit", i_NumberOfDigitsGreaterThanTheFirstDigit));
        }

    }
}
