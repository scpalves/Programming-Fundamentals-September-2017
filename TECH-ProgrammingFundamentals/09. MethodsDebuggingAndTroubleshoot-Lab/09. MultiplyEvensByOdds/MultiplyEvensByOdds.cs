using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultiplyEvensByOdds
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"{MultiplyNumbs(Math.Abs(n))}");
    }

    static int GetSumOffEvenDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int lastDigit = n % 10;
            if (lastDigit % 2 == 0)
            {
                sum += lastDigit;
            }
            n /= 10;
        }
        return sum;
    }

    static int GetSumOffOddDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int lastDigit = n % 10;
            if (lastDigit % 2 != 0)
            {
                sum += lastDigit;
            }
            n /= 10;
        }
        return sum;
    }

    static int MultiplyNumbs(int n)
    {
        int evenSum = GetSumOffEvenDigits(n);
        int oddSum = GetSumOffOddDigits(n);
        return evenSum * oddSum;
    }
}

