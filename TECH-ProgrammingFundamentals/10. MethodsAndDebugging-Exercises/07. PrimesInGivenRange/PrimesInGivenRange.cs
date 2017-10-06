using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimesInGivenRange
{
    static void Main()
    {
        var start = long.Parse(Console.ReadLine());
        var end = long.Parse(Console.ReadLine());

        var result = PrimeNumbersInGivenRange(start, end);
        Console.WriteLine(string.Join(", ",result));
    }

    static List<long> PrimeNumbersInGivenRange(long start, long end)
    {
        var primeNumbers = new List<long>();
        var cnt = 0;
        for (long a = start; a <= end; a++)
        {
            for (long b = 1; b <= end; b++)
            {
                if (a % b == 0)
                {
                    cnt++;
                }
            }
            if (cnt == 2)
            {
                primeNumbers.Add(a);
            }
            cnt = 0;
        }
        return primeNumbers;
    }
}

