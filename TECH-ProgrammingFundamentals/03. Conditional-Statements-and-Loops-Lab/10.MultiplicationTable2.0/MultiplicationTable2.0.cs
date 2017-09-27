using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultiplicationTable2
{
    static void Main()
    {
        var numberToMultiply = int.Parse(Console.ReadLine());
        var timesToMultiply = int.Parse(Console.ReadLine());
        var resultOfMultiply = 1;
        if (timesToMultiply > 10)
        {
            resultOfMultiply = numberToMultiply * timesToMultiply;
            Console.WriteLine($"{numberToMultiply} X {timesToMultiply} = {resultOfMultiply}");
        }
        else
        {
            for (int i = timesToMultiply; i <= 10; i++)
            {
                resultOfMultiply = numberToMultiply * i;
                Console.WriteLine($"{numberToMultiply} X {i} = {resultOfMultiply}");
            }
        }
    }
}

