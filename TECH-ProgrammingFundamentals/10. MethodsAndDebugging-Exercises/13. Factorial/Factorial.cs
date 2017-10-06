using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Factorial
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var result = FindTheFactorial(number);
        Console.WriteLine(result);
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
}

