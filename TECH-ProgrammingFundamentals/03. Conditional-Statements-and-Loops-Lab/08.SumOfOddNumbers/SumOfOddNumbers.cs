using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfOddNumbers
{
    static void Main(string[] args)
    {
        var countOfOddNumbers = int.Parse(Console.ReadLine());
        var sumOfOddNumbers = 0;

        for (int i = 1; i <= countOfOddNumbers; i++)
        {
            Console.WriteLine(2 * i - 1);
            sumOfOddNumbers += 2 * i - 1;
        }
        Console.WriteLine($"Sum: {sumOfOddNumbers}");
    }
}

