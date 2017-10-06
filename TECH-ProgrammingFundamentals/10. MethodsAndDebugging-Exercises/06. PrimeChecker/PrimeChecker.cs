using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeChecker
{
    static void Main()
    {
        var number = long.Parse(Console.ReadLine());

        if (!(IsPrime(number)) || number == 0)
        {
            Console.WriteLine("False");
        }
        else
        {
            Console.WriteLine("True");
        }

    }

    static bool IsPrime(long number)
    {

        if (number == 1) return false;
        if (number == 2) return true;

        for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;

    }
}
