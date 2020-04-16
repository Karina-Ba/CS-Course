
//EXE

class Program
{
    static void Main()
    {
        InitProgram();
    }

    static void InitProgram()
    {
        string userInput1, userInput2, userInput3;
        double numFromFunction1, numFromFunction2, numFromFunction3;
        float i_averageNumOfOnesInStrings = 0;
        float i_averageNumOfZerosInStrings;
        int i_amountOfPowerTwoNumbers = 0;
        int i_amountOfNumbersThatAreARisingSeries = 0;
        double i_maxNumber, i_minNumber;
        System.Console.WriteLine("Tequila!");
        userInput1 = GetUserInput();
        userInput2 = GetUserInput();
        userInput3 = GetUserInput();
        numFromFunction1 = ConvertBinaryNumberToInt(userInput1);
        numFromFunction2 = ConvertBinaryNumberToInt(userInput2);
        numFromFunction3 = ConvertBinaryNumberToInt(userInput3);
        i_averageNumOfOnesInStrings += getNumOfOnes(userInput1);
        i_averageNumOfOnesInStrings += getNumOfOnes(userInput2);
        i_averageNumOfOnesInStrings += getNumOfOnes(userInput3);
        i_averageNumOfZerosInStrings = 27 - i_averageNumOfOnesInStrings;
        i_averageNumOfOnesInStrings = i_averageNumOfOnesInStrings / 3;
        i_averageNumOfZerosInStrings = i_averageNumOfZerosInStrings / 3;
        System.Console.WriteLine(string.Format(
            @"The average number of ones in the three sets is: {0} 
              The average number of zeros in the three sets is: {1}",
            i_averageNumOfOnesInStrings.ToString(),
            i_averageNumOfZerosInStrings.ToString()));
        
        if(isPowerOfTwo(numFromFunction1))
        {
            i_amountOfPowerTwoNumbers++;
        }
        if (isPowerOfTwo(numFromFunction2))
        {
            i_amountOfPowerTwoNumbers++;
        }
        if (isPowerOfTwo(numFromFunction3))
        {
            i_amountOfPowerTwoNumbers++;
        }
        System.Console.WriteLine(string.Format("The amount of numbers that are power of 2 are: {0}\n", i_amountOfPowerTwoNumbers.ToString()));
        if(isARisingSeries(numFromFunction1))
        {
            i_amountOfNumbersThatAreARisingSeries++;
        }
        if (isARisingSeries(numFromFunction2))
        {
            i_amountOfNumbersThatAreARisingSeries++;
        }
        if (isARisingSeries(numFromFunction3))
        {
            i_amountOfNumbersThatAreARisingSeries++;
        }
        System.Console.WriteLine(string.Format("The amount of numbers that are a rising series are: {0}\n", i_amountOfNumbersThatAreARisingSeries.ToString()));
        i_maxNumber = returnMaxNumberFromThree(numFromFunction1, numFromFunction2, numFromFunction3);
        i_minNumber = returnMinNumberFromThree(numFromFunction1, numFromFunction2, numFromFunction3);
        System.Console.WriteLine(string.Format("The biggest number is: {0} \n The smallest number is: {1}\n", i_maxNumber.ToString(), i_minNumber.ToString()));
    }
    //check if the number is power of 2
    static bool isPowerOfTwo(double io_number)
    {
        if (io_number == 0)
            return false;

        while (io_number != 1)
        {
            if (io_number % 2 != 0)
                return false;

            io_number = io_number / 2;
        }
        return true; 
    }

    //get the user input string, and check for good input
    static string GetUserInput()
    {
        string io_Input;
        bool v_IsBadInput = true;
        int i_countAmountOfNumbersInBinarySet = 0;
        io_Input = System.Console.ReadLine();
        while(v_IsBadInput)
        {
            foreach(char c in io_Input)
            {
                if(c != '1' && c != '0' )
                {
                    System.Console.WriteLine("Invalid input, please enter another:\n");
                    io_Input = System.Console.ReadLine();
                    v_IsBadInput = true;
                    break;
                }
                v_IsBadInput = false;
                i_countAmountOfNumbersInBinarySet++;
            }
            if(i_countAmountOfNumbersInBinarySet != 9)
            {
                System.Console.WriteLine("The series is too long, please enter another:\n");
                io_Input = System.Console.ReadLine();
                v_IsBadInput = true;
            }
        }
        return io_Input;
    }
    //Convert binary number to decimal number
    static double ConvertBinaryNumberToInt(string io_stringToConvert)
    {
        double io_stringNum =0;
        double i_Exponent = 0;
        foreach(char c in io_stringToConvert )
        {
            if(c == 1)
            {
                io_stringNum += System.Math.Pow(2.0, i_Exponent);
            }
            i_Exponent++;
        }
        return io_stringNum;
    }
    //return the number on ones in the string
    static float getNumOfOnes(string io_stringToCount)
    {
        float io_numberOfOnes = 0;
        foreach(char c in io_stringToCount)
        {
            if (c == '1')
            {
                io_numberOfOnes++;
            }
        }
        return io_numberOfOnes;
    }
    
    static bool isARisingSeries(double io_numToCheckForRisingSeries)
    {
        bool isRisingSeries = true;
        int currentDigit = 0;
        int previousDigit = io_numToCheckForRisingSeries % 10;
        io_numToCheckForRisingSeries = io_numToCheckForRisingSeries / 10;
        while(io_numToCheckForRisingSeries > 0 )
        {
            currentDigit = io_numToCheckForRisingSeries % 10;
            if(currentDigit <= previousDigit)
            {
                isRisingSeries = false;
            }
        }
        return isRisingSeries;
    }

    static double returnMaxNumberFromThree(double io_num1, double io_num2, double io_num3)
    {
        double maxNum;
        if(io_num1 >= io_num2 && io_num1 >= io_num3)
        {
            maxNum = io_num1;
        }
        if (io_num3 >= io_num2 && io_num2 >= io_num3)
        {
            maxNum = io_num2;
        }
        else
        {
            maxNum = io_num3;
        }
        return maxNum;
    }
    static double returnMinNumberFromThree(double io_num1, double io_num2, double io_num3)
    {
        double minNum;
        if (io_num1 <= io_num2 && io_num1 <= io_num3)
        {
            minNum = io_num1;
        }
        if (io_num3 <= io_num2 && io_num2 <= io_num3)
        {
            minNum = io_num2;
        }
        else
        {
            minNum = io_num3;
        }
        return minNum;
    }
}