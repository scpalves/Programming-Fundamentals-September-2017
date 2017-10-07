using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class LastKNumbersSums
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var k = int.Parse(Console.ReadLine());
        var numbers = new long[n];
        numbers[0] = 1;

        for (int i = 1; i < n; i++)
        {
            var count = k;
            var sum = 0L;
            for (int b = i - 1; b >= 0; b--)
            {
                if (count == 0)
                {
                    break;
                }
                sum += numbers[b];
                count--;
            }
            numbers[i] = sum;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
