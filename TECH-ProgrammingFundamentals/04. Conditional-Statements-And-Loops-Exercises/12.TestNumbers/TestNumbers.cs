using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestNumbers
{
    static void Main()
    {
        var firstNumber = int.Parse(Console.ReadLine());
        var secondNUmber = int.Parse(Console.ReadLine());
        var controlNumber = int.Parse(Console.ReadLine());

        var isOverControlNumber = false;
        var counter = 0;
        var totalSum = 0;

        for (int a = firstNumber; a >= 1; a--)
        {
            for (int b = 1; b <= secondNUmber; b++)
            {
                totalSum += (a * b) * 3;
                counter++;
                if (totalSum >= controlNumber)
                {
                    isOverControlNumber = true;
                    Console.WriteLine($"{counter} combinations");
                    Console.WriteLine($"Sum: {totalSum} >= {controlNumber}");
                    return;
                }
            }
        }

        if (!isOverControlNumber)
        {
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}

