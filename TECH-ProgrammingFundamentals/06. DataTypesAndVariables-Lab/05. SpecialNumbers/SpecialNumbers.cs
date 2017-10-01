﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SpecialNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            int sumOfDigits = 0;
            int digits = i;
            while (digits > 0)
            {
                sumOfDigits += digits % 10;
                digits = digits / 10;
            }
            bool isSpecialNumber = (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);
            Console.WriteLine($"{i} -> {isSpecialNumber}");
        }
    }
}
