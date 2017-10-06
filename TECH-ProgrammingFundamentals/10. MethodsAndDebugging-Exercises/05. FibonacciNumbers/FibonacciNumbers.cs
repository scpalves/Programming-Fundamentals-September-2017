using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            FindMasterNumsInRange(number);

        }

        static void FindMasterNumsInRange(int number)
        {
            for (int i = 1; i <= number; i++)
            {

                if (CheckIfNumberIsSymmetric(i))
                {
                    if (isSumOfDigitsDivisibleBy7(i))
                    {
                        if (isThereEvenDigitInNum(i))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    continue;
                }

            }

        }

        static bool isThereEvenDigitInNum(int number)
        {

            while (number != 0)
            {

                if ((number % 10) % 2 == 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        static bool isSumOfDigitsDivisibleBy7(int number)
        {
            int sumOfDigits = 0;
            while (number != 0)
            {
                sumOfDigits += number % 10;
                number /= 10;
            }

            if (sumOfDigits % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool CheckIfNumberIsSymmetric(int number)
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
    }
}