using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumbersInReversedOrder
{
    static void Main()
    {
        var number = decimal.Parse(Console.ReadLine());

        var reversedNumber = ReversedNumber(number);
        Console.WriteLine(reversedNumber);
    }

    static string ReversedNumber(decimal number)
    {
        var saveNumber = string.Empty;
        while (number > 0)
        {
            var lastDigit = number % 10;
            saveNumber += lastDigit.ToString();
            number = Math.Floor(number /= 10);
        }
        return saveNumber;
    }
}

