using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayStatistics
{
    static void Main()
    {
        var numbers =
            Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        var min = numbers.Min();
        var max = numbers.Max();
        var sum = numbers.Sum();
        var average = numbers.Average();

        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average}");
    }
}

