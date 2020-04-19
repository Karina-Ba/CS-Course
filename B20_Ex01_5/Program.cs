class Program
{
    static void Main()
    {
        initiateProgram();
    }

    static void initiateProgram()
    {
        string i_UserInputString;
        bool i_isLegalInput = false;
        System.Console.WriteLine("Please enter a string");
        i_UserInputString = System.Console.ReadLine();
        i_isLegalInput = checkUserInputString(i_UserInputString);
        while(i_isLegalInput == false)
        {
            System.Console.WriteLine("Invalid input, please enter another:");
            i_UserInputString = System.Console.ReadLine();
            i_isLegalInput = checkUserInputString(i_UserInputString);
        }
        printMaximumDigit(i_UserInputString);
        printMinimumDigit(i_UserInputString);
        countDigitsDevidedByTheeNoRemain(i_UserInputString);
        countNumOfDigitsGreaterThanTheFirstDigit(i_UserInputString);
    }

    static bool checkUserInputString(string io_userInputString)
    {
        if(io_userInputString.Length != 9)
        {
            return false;
        }
        foreach(char i_charToCheck in io_userInputString)
        {
            if(!char.IsDigit(i_charToCheck))
            {
                return false;
            }
        }
        return true;
    }

    static void printMaximumDigit(string io_number)
    {
        double i_maxDigit = 0;
        double i_currentDigit;
        foreach(char i_digitToCheck in io_number)
        {
            i_currentDigit = char.GetNumericValue(i_digitToCheck);
            if(i_currentDigit >= i_maxDigit)
            {
                i_maxDigit = i_currentDigit;
            }
        }
        System.Console.WriteLine(string.Format("The maximum digit in the string is: ", i_maxDigit.ToString()));
    }

    static void printMinimumDigit(string io_number)
    {
        double i_minDigit = 0;
        double i_currentDigit;
        foreach (char i_digitToCheck in io_number)
        {
            i_currentDigit = char.GetNumericValue(i_digitToCheck);
            if (i_currentDigit <= i_minDigit)
            {
                i_minDigit = i_currentDigit;
            }
        }
        System.Console.WriteLine(string.Format("The minimum digit in the string is: ", i_minDigit.ToString()));

    }

    static void countDigitsDevidedByTheeNoRemain(string io_number)
    {
        int i_numOfDigitsDevidedByThreeWithoutRemaim = 0;
        double i_currentDigit;
        foreach(char i_DigitToCheck in io_number)
        {
            i_currentDigit = char.GetNumericValue(i_DigitToCheck);
            if(i_currentDigit%3 == 0)
            {
                i_numOfDigitsDevidedByThreeWithoutRemaim++;
            }
        }
        System.Console.WriteLine(string.Format("The number of digits devided by 3 without a remain is:{0}", i_numOfDigitsDevidedByThreeWithoutRemaim.ToString()));
    }

    static void countNumOfDigitsGreaterThanTheFirstDigit(string io_number)
    {
        int i_numberOfDigitsGreaterThanTheFirstDigit=0;
        double i_firstDigit = char.GetNumericValue(io_number[io_number.Length - 1]);
        double i_currentDigitToCheck;
        foreach (char i_digitToCheck in io_number)
        {
            i_currentDigitToCheck = char.GetNumericValue(i_digitToCheck);
            if(i_currentDigitToCheck > i_firstDigit)
            {
                i_numberOfDigitsGreaterThanTheFirstDigit++;
            }
        }
        System.Console.WriteLine(string.Format("There are {0} digits greater than the first digit",i_numberOfDigitsGreaterThanTheFirstDigit));
    }

}
