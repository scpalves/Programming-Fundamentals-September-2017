using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnglishNameOfLastDigit
{
    static void Main()
    {
        var number = long.Parse(Console.ReadLine());

        var lastDigit = NameOfLastDigit(number);
        Console.WriteLine(lastDigit);
    }

    static string NameOfLastDigit(long number)
    {
        var lastDigit = Math.Abs(number % 10);
        switch (lastDigit)
        {
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
        }
        return "zero";
    }
}

