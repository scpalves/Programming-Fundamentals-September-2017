using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FoldAndSum
{
    static void Main()
    {
        var numbers =
            Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        var smallPartsOfArray = numbers.Length / 4;
        var leftPart = numbers.Take(smallPartsOfArray).Reverse().ToArray();
        var middlePart = numbers.Skip(smallPartsOfArray).Take(smallPartsOfArray * 2).ToArray();
        var rightPart = numbers.Skip(smallPartsOfArray * 3).Take(smallPartsOfArray).Reverse().ToArray();
        var leftAndRightPartTogether = leftPart.Concat(rightPart).ToArray();

        for (int i = 0; i < middlePart.Length; i++)
        {
            middlePart[i] += leftAndRightPartTogether[i];
        }

        Console.WriteLine(string.Join(" ",middlePart));
    }
}

