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
        int stringNumberRepresentation;
        bool isLegalInput = false;
        System.Console.WriteLine("Please enter a string:");
        userInputString = System.Console.ReadLine();
        isLegalInput = checkUserInputString(userInputString);
        while(isLegalInput == false)
        {
            System.Console.WriteLine("Invalid input, please enter another:");
            userInputString = System.Console.ReadLine();
            isLegalInput = checkUserInputString(userInputString);
        }

        checkIfTheStringIsPalindrome(userInputString);
        if(int.TryParse(userInputString,out stringNumberRepresentation))
        {
            checkIfNumberDividedByFiveWithoutARemain(stringNumberRepresentation);
        }
        else
        {
            countNumOfUpercases(userInputString);
        }

    }
    //-----------------------------------------------------------------------------------------------------------------------//
    //check for a valid input
    private static bool checkUserInputString(string i_UserInputString)
    {
        bool isTheUserInputLegal = true;
        bool isNumberChar = false;
        bool isLetterChar = false;
        if(i_UserInputString.Length != 8)
        {
            isTheUserInputLegal = false;
        }
        foreach(char currentStringChar in i_UserInputString)
        {
            if (char.IsDigit(currentStringChar))
            {
                isNumberChar = true;
            }
            else if (char.IsLetter(currentStringChar))
            {
                isLetterChar = true;
            }
            else
            {
                isTheUserInputLegal = false;
                break;
            }
            if (isNumberChar == true && isLetterChar == true)
            {
                isTheUserInputLegal = false;
                break;
            }
        }
        return isTheUserInputLegal;
    }
    //-----------------------------------------------------------------------------------------------------------------------//
    //check if the string is palindrome
    private static void checkIfTheStringIsPalindrome(string i_StringToCheck)
    {
        
        int startIndex = 0;
        int endIndex = i_StringToCheck.Length-1;
        if(checkPalindromeForStringRecursive(i_StringToCheck, startIndex, endIndex))
        {
            System.Console.WriteLine("The string is Palindrome");
        }
        else
        {
            System.Console.WriteLine("The string is not Palindrome");

        }
    }
    //-----------------------------------------------------------------------------------------------------------------------//
    //check Palindrome recursive method
    private static bool checkPalindromeForStringRecursive(string i_StringToCheck, int i_LeftIndexOfCharToCheck, int i_RightIndexOfCharToCheck)
    {
        bool isPalindrome = true;
        if(i_LeftIndexOfCharToCheck > i_RightIndexOfCharToCheck)
        {
            isPalindrome = true;
        }
        else
        {
            if(i_StringToCheck[i_LeftIndexOfCharToCheck] != i_StringToCheck[i_RightIndexOfCharToCheck])
            {
                isPalindrome = false;
            }
            else
            {
                isPalindrome = checkPalindromeForStringRecursive(i_StringToCheck, i_LeftIndexOfCharToCheck + 1, i_RightIndexOfCharToCheck - 1);
            }
        }
        return isPalindrome;
    }
    //-----------------------------------------------------------------------------------------------------------------------//
    private static void countNumOfUpercases(string i_StringToCheck)
    {
        int numOfUpercases = 0;
        foreach(char i_currentStringChar in i_StringToCheck)
        {
            if(char.IsUpper(i_currentStringChar))
            {
                numOfUpercases++;
            }
        }
        if(numOfUpercases == 0)
        {
            System.Console.WriteLine("There are no Uppercases in the string\n");
        }
        else
        {
            System.Console.WriteLine(string.Format("The number of Uppercases in the string is: {0}\n", numOfUpercases));

        }
    }
    //-----------------------------------------------------------------------------------------------------------------------//
    private static void checkIfNumberDividedByFiveWithoutARemain(int i_Number)
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
    //-----------------------------------------------------------------------------------------------------------------------//
}