using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSequenceOfIncreasingElements
{
    static void Main()
    {
        var numbers =
            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        var currentSequnce = new List<int>();
        currentSequnce.Add(numbers[0]);
        int currentCounter = 0;
        var finalSequnce = new List<int>();
        int finalCounter = 0;

        FindingMaxSequenceOfIncreasingElements(numbers, currentSequnce, ref currentCounter, finalSequnce, ref finalCounter);
        Console.WriteLine(string.Join(" ",finalSequnce));
    }

    private static void FindingMaxSequenceOfIncreasingElements(int[] numbers, List<int> currentSequnce,
        ref int currentCounter, List<int> finalSequnce, ref int finalCounter)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                currentCounter++;
                currentSequnce.Add(numbers[i + 1]);
            }
            else
            {
                currentCounter = 0;
                currentSequnce.Clear();
                currentSequnce.Add(numbers[i + 1]);
            }

            if (currentCounter > finalCounter)
            {
                finalSequnce.Clear();
                finalSequnce.AddRange(currentSequnce);
                finalCounter = currentCounter;
            }
        }
    }
}

