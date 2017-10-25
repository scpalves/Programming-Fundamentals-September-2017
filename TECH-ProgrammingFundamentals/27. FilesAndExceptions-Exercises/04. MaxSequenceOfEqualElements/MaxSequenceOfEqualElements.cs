namespace _04.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = File.ReadAllText("../../input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            File.Delete("../../output.txt");

            int equalNumbersCount = 1;
            int maxEqualNumbersCount = 1;
            int saveBestNumber = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNumber = numbers[i];
                int nextNumber = numbers[i + 1];

                if (currentNumber == nextNumber)
                {
                    equalNumbersCount++;
                    if (equalNumbersCount > maxEqualNumbersCount)
                    {
                        saveBestNumber = 0;
                        saveBestNumber = currentNumber;
                        maxEqualNumbersCount = equalNumbersCount;
                    }
                }
                else
                {
                    equalNumbersCount = 1;
                }
            }

            var maxSequnceOfEqualElements = new int[maxEqualNumbersCount];
            for (int i = 0; i < maxSequnceOfEqualElements.Length; i++)
            {
                maxSequnceOfEqualElements[i] = saveBestNumber;
            }

            File.AppendAllText("../../output.txt", string.Join(" ", maxSequnceOfEqualElements));
        }
    }
}
