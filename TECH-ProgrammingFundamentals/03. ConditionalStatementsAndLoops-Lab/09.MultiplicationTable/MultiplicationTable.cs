using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultiplicationTable
{
    static void Main()
    {
        var numberToMultiply = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            var resultOfMultiply = numberToMultiply * i;
            Console.WriteLine($"{numberToMultiply} X {i} = {resultOfMultiply}");
        }
    }
}

