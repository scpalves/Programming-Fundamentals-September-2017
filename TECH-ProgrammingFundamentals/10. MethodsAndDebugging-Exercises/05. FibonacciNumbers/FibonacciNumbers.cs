using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FibonacciNumber
{
    static void Main()
    {
        long fibonaciNthNumber = long.Parse(Console.ReadLine());

        var nthNumber = FibonacciNumbers(fibonaciNthNumber);
        Console.WriteLine(nthNumber);
    }

    static long FibonacciNumbers(long number)
    {
        long firstNumber = 0;
        long secondNumber = 1;
        long fibonacciNumber = secondNumber;
        for (int i = 1; i <= number; i++)
        {
            fibonacciNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = fibonacciNumber;
        }
        return fibonacciNumber;
    }

}

