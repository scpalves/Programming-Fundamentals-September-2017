using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] numbers =
            Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        var currentSequence = new List<int>();
        currentSequence.Add(numbers[0]);
        int currentCounter = 0;
        int finalCounter = 0;
        var finalSequence = new List<int>();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                currentCounter++;
                currentSequence.Add(numbers[i + 1]);
            }
            else
            {
                currentCounter = 0;
                currentSequence.Clear();
                currentSequence.Add(numbers[i + 1]);
            }

            if (currentCounter > finalCounter)
            {
                finalCounter = currentCounter;
                finalSequence.Clear();
                finalSequence.AddRange(currentSequence);
            }
        }

        Console.WriteLine(string.Join(" ",finalSequence));
    }
}

