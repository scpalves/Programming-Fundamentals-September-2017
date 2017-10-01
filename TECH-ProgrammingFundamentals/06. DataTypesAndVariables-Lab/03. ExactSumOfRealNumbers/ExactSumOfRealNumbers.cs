using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExactSumOfRealNumbers
{
    static void Main()
    {
        var numbersCount = int.Parse(Console.ReadLine());
        var finalResult = 0m;

        for (int i = 0; i < numbersCount; i++)
        {
            var numbers = decimal.Parse(Console.ReadLine());
            finalResult += numbers;
        }

        Console.WriteLine(finalResult);
    }
}

