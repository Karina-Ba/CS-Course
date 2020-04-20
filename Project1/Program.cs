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
        bool i_IsLegalInput = false;
        System.Console.WriteLine("Please enter a string:");
        i_UserInputString = System.Console.ReadLine();
        i_IsLegalInput = CheckUserInputString(i_UserInputString);
        while(i_IsLegalInput == false)
        {
            System.Console.WriteLine("Invalid input, please enter another:");
            i_UserInputString = System.Console.ReadLine();
            i_IsLegalInput = CheckUserInputString(i_UserInputString);
        }

        CheckIfTheStringIsPalindrome(i_UserInputString);
        if(int.TryParse(i_UserInputString,out i_StringNumberRepresentation))
        {
            CheckIfNumberDividedByFiveWithoutARemain(i_StringNumberRepresentation);
        }
        else
        {
            CountNumOfUpercases(i_UserInputString);
        }

    }

    //check for a valid input
    static bool CheckUserInputString(string i_UserInputString)
    {
        bool i_IsNumberChar = false;
        bool i_IsLetterChar = false;
        if(i_UserInputString.Length != 8)
        {
            return false;
        }
        foreach(char i_CurrentStringChar in i_UserInputString)
        {
            if (char.IsDigit(i_CurrentStringChar))
            {
                i_IsNumberChar = true;
            }
            else if (char.IsLetter(i_CurrentStringChar))
            {
                i_IsLetterChar = true;
            }
            else
            {
                return false;
            }
            if (i_IsNumberChar == true && i_IsLetterChar == true)
            {
                return false;
            }
        }
        return true;
    }


    //check if the string is palindrome
    static void CheckIfTheStringIsPalindrome(string i_StringToCheck)
    {
        
        int i_StartIndex = 0;
        int i_EndIndex = i_StringToCheck.Length-1;
        if(CheckIfTheStringIsPalindromeRecursive(i_StringToCheck, i_StartIndex, i_EndIndex))
        {
            System.Console.WriteLine("The string is Palindrome");
        }
        else
        {
            System.Console.WriteLine("The string is not Palindrome");

        }
    }

    //check Palindrome recursive method
    static bool CheckIfTheStringIsPalindromeRecursive(string i_StringToCheck, int i_LeftIndexOfCharToCheck, int i_RightIndexOfCharToCheck)
    {
        if(i_LeftIndexOfCharToCheck > i_RightIndexOfCharToCheck)
        {
            return true;
        }
        else
        {
            if(i_StringToCheck[i_LeftIndexOfCharToCheck] != i_StringToCheck[i_RightIndexOfCharToCheck])
            {
                return false;
            }
            else
            {
                return CheckIfTheStringIsPalindromeRecursive(i_StringToCheck, i_LeftIndexOfCharToCheck + 1, i_RightIndexOfCharToCheck - 1);
            }
        }

    }

    static void CountNumOfUpercases(string i_StringToCheck)
    {
        int i_NumOfUppercases = 0;
        foreach(char i_currentStringChar in i_StringToCheck)
        {
            if(char.IsUpper(i_currentStringChar))
            {
                i_NumOfUppercases++;
            }
        }
        if(i_NumOfUppercases == 0)
        {
            System.Console.WriteLine("There are no Uppercases in the string\n");
        }
        else
        {
            System.Console.WriteLine(string.Format("The number of Uppercases in the string is: {0}\n", i_NumOfUppercases));

        }
    }

    static void CheckIfNumberDividedByFiveWithoutARemain(int i_Number)
    {
        if (i_Number % 5 == 0)
        {
            System.Console.WriteLine("The number is divided by 5 without a remain\n");
        }
        else
        {
            System.Console.WriteLine("The number is not divided by 5 without a remain\n");
        }
    }
}