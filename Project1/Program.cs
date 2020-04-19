class Program
{
    static void Main()
    {
        ProgramInitiation();
    }

    static void ProgramInitiation()
    {
        string i_UserInputString;
        int i_StringNumberRepresentation;
        bool i_isLegalInput = false;
        System.Console.WriteLine("Please enter a string:\n");
        i_UserInputString = System.Console.ReadLine();
        i_isLegalInput = checkUserInputString(i_UserInputString);
        while(i_isLegalInput == false)
        {
            System.Console.WriteLine("Invalid input, please enter another:\n");
            i_UserInputString = System.Console.ReadLine();
            i_isLegalInput = checkUserInputString(i_UserInputString);
        }

        checkPalindrome(i_UserInputString);
        if(int.TryParse(i_UserInputString,out i_StringNumberRepresentation))
        {
            checkIfModuleFive(i_StringNumberRepresentation);

        }
        else
        {
            checkNumOfUpperCases(i_UserInputString);
        }

    }

    //check for a valid input
    static bool checkUserInputString(string io_userInputString)
    {
        bool i_isNumberChar = false;
        bool i_isLetterChar = false;
        foreach(char i_currentStringChar in io_userInputString)
        {
            if (i_currentStringChar >= '0' && i_currentStringChar <= '9')
            {
                i_isNumberChar = true;
            }
            else if (i_currentStringChar >= 'A' && i_currentStringChar <= 'Z')
            {
                i_isLetterChar = true;
            }
            else if (i_currentStringChar >= 'a' && i_currentStringChar <= 'z')
            {
                i_isLetterChar = true;
            }
            else
            {
                return false;
            }
            if (i_isNumberChar == true && i_isLetterChar == true)
            {
                return false;
            }
        }
        return true;
    }


    //check if the string is palindrome
    static void checkPalindrome(string io_StringToCheck)
    {
        int leftString = 0;
        int rightString = io_StringToCheck.Length;
        if(checkPalindromeRecursive(io_StringToCheck, leftString, rightString))
        {
            System.Console.WriteLine("The string is Palindrome");
        }
        else
        {
            System.Console.WriteLine("The string is not Palindrome");

        }
    }

    //check Palindrome recursive method
    static bool checkPalindromeRecursive(string io_StringToCheck, int io_left, int io_right)
    {
        if(io_left > io_right)
        {
            return true;
        }
        else
        {
            if(io_StringToCheck[io_left] != io_StringToCheck[io_right])
            {
                return false;
            }
            else
            {
                return checkPalindromeRecursive(io_StringToCheck, io_left + 1, io_right - 1);
            }
        }

    }

    static void checkNumOfUpperCases(string io_stringToCheck)
    {
        int i_numOfUpperCase = 0;
        foreach(char c in io_stringToCheck)
        {
            if(c >= 'A' && c <= 'Z')
            {
                i_numOfUpperCase++;
            }
        }
        if(i_numOfUpperCase == 0)
        {
            System.Console.WriteLine("There are no Uppercases in the string\n");
        }
        else
        {
            System.Console.WriteLine(string.Format("The number of Uppercases in the string is: {0}\n", i_numOfUpperCase));

        }
    }

    static void checkIfModuleFive(int io_numberToCheck)
    {
        int i_numberRemain =io_numberToCheck % 5;
        if (i_numberRemain ==0)
        {
            System.Console.WriteLine("The number is divided by 5 without a remain\n");
        }
        else
        {
            System.Console.WriteLine("The number is nod divided by 5 without a remain\n");
        }
    }
}