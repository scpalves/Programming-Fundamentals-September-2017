using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IntervalOfNumbers
{
    static void Main()
    {
        var start = int.Parse(Console.ReadLine());
        var end = int.Parse(Console.ReadLine());

        var startValue = Math.Min(start, end);
        var endValue = Math.Max(start, end);

        for (int i = startValue; i <= endValue; i++)
        {
            Console.WriteLine(i);
        }
    }
}

