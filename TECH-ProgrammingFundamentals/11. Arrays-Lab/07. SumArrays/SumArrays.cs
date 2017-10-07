using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumArrays
{
    static void Main()
    {
        int[] firstNumbers, secondNumbers;
        ReadingInput(out firstNumbers, out secondNumbers);
        var maxArrayLenght = Math.Max(firstNumbers.Length, secondNumbers.Length);
        var result = new int[maxArrayLenght];

        for (int i = 0; i < maxArrayLenght; i++)
        {
            result[i] = firstNumbers[i % firstNumbers.Length] + secondNumbers[i % secondNumbers.Length];
        }

        Console.WriteLine(string.Join(" ", result));
    }

    private static void ReadingInput(out int[] firstNumbers, out int[] secondNumbers)
    {
        firstNumbers = Console.ReadLine()
             .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

        secondNumbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}

