using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RotateAndSum
{
    static void Main()
    {
        var numbers =
            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        var rotations = int.Parse(Console.ReadLine());
        var result = new int[numbers.Length];

        for (int i = 0; i < rotations; i++)
        {
            var firstElement = numbers[numbers.Length - 1];
            for (int j = numbers.Length - 1; j > 0; j--)
            {
                numbers[j] = numbers[j - 1];
            }
            numbers[0] = firstElement;

            for (int j = 0; j < numbers.Length; j++)
            {
                result[j] += numbers[j];
            }
        }

        Console.WriteLine(string.Join(" ",result));
    }
}

