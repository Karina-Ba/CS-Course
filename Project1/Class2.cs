class Program
{
    static void Main()
    {

    }

    static void ProgramInitiation()
    {
        string io_UserInputString;
        bool i_isNumberString = false;
        bool i_isLetterString = false;
        bool i_isLegalInput = false;
        io_UserInputString = System.Console.ReadLine();
        while(i_isLegalInput == false)
        {
            foreach (char c in io_UserInputString)
            {
                if (c >= '0' || c <= '9')
                {
                    i_isNumberString = true;
                }
                else if (c >= 'A' || c <= 'Z')
                {
                    i_isLetterString = true;
                }
                else if (c >= 'a' || c <= 'z')
                {
                    i_isLetterString = true;
                }
                else
                {
                    i_isNumberString = false;
                    i_isLetterString = false;
                    i_isLegalInput = false;
                    System.Console.WriteLine("Invalid input, please enter another: \n");
                    io_UserInputString = System.Console.ReadLine();

                    break;
                }
                if (i_isNumberString == true && i_isLetterString == true)
                {
                    i_isNumberString = false;
                    i_isLetterString = false;
                    i_isLegalInput = false;
                    System.Console.WriteLine("Invalid input, please enter another: \n");
                    io_UserInputString = System.Console.ReadLine();
                    break;
                }
            }
        }

        checkPalindrome(io_UserInputString);
        if(i_isLetterString == true)
        {
            checkNumOfUpperCases(io_UserInputString);
        }
        else
        {
            checkIfModuleFive(io_UserInputString);
        }
        
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

    static void checkIfModuleFive(string io_stringToCheck)
    {
       if(int.Parse(io_stringToCheck)%5 ==0)
       {
            System.Console.WriteLine("The number is divided by 5 without a remain\n");
       }
       else
       {
            System.Console.WriteLine("The number is divided by 5 without a remain \n");
       }
    }
}