using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FastPrimeChecker
{
    static void Main()
    {
        int endOfRange = int.Parse(Console.ReadLine());
        for (int startOfRange = 2; startOfRange <= endOfRange; startOfRange++)
        {
            bool isPrime = true;
            for (int currentNumber = 2; currentNumber <= Math.Sqrt(startOfRange); currentNumber++)
            {
                if (startOfRange % currentNumber == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{startOfRange} -> {isPrime}");
        }

    }
}

