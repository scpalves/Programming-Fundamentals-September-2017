using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if (IsPalindrome(i) && IsSumOfDigitsDivisbleBy7(i) && IsContainingOneEvenDigit(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPalindrome(int number)
    {
        int n = number;
        int reversedNumber = 0;
        while (number > 0)
        {
            int dig = number % 10;
            reversedNumber = reversedNumber * 10 + dig;
            number = number / 10;
        }

        if (n == reversedNumber)
        {
            return true;
        }

        return false;
    }

    static bool IsSumOfDigitsDivisbleBy7(int number)
    {
        var numberToString = number.ToString();
        var sum = 0;
        for (int i = 0; i < numberToString.Length; i++)
        {
            sum += int.Parse(numberToString[i].ToString());
        }
        if (sum % 7 == 0)
        {
            return true;
        }
        return false;
    }

    static bool IsContainingOneEvenDigit(int number)
    {
        var numberToString = number.ToString();
        for (int i = 0; i < numberToString.Length; i++)
        {
            var currentNumber = int.Parse(numberToString[i].ToString());
            if (currentNumber % 2 == 0)
            {
                return true;
            }
        }
        return false;
    }
}

