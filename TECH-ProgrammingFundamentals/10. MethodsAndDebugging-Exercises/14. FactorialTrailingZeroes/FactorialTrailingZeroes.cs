using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class FactorialTrailingZeroes
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var result = FindTheFactorial(number);
        var numberOfZero = Zeros(result);
        Console.WriteLine(numberOfZero);
    }

    static BigInteger FindTheFactorial(int number)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    static int Zeros(BigInteger factorial)
    {
        int zero = 0;
        while (factorial % 10 == 0)
        {
            zero++;
            factorial /= 10;
        }
        return zero;
    }
}

