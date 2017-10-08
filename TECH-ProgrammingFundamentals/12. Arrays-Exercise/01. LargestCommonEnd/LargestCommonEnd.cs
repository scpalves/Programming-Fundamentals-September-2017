using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestCommonEnd
{
    static void Main()
    {
        var firstArray =
            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var secondArray =
            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        var shorterArray = Math.Min(firstArray.Length, secondArray.Length);
        var leftCounter = 0;
        var rightCounter = 0;

        leftCounter = CountingForEqualWordsInArray(firstArray, secondArray, shorterArray, leftCounter);
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);
        rightCounter = CountingForEqualWordsInArray(firstArray, secondArray, shorterArray, rightCounter);

        var largerSequence = Math.Max(leftCounter, rightCounter);
        Console.WriteLine(largerSequence);
    }

    private static int CountingForEqualWordsInArray(string[] firstArray, string[] secondArray, int shorterArray, int leftCounter)
    {
        for (int i = 0; i < shorterArray; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                leftCounter++;
            }
        }

        return leftCounter;
    }
}

