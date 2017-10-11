namespace _04.LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var lenght = new int[numbers.Length];
            var preveous = new int[numbers.Length];
            int maxIndex = 0;
            int maxLenght = 0;

            for (int x = 0; x < numbers.Length; x++)
            {
                lenght[x] = 0;
                preveous[x] = -1;
                for (int i = 0; i < x; i++)
                {
                    if (numbers[x] > numbers[i] && lenght[i] + 1 > lenght[x])
                    {
                        lenght[x] = lenght[i] + 1;
                        preveous[x] = i;
                    }
                }

                if (lenght[x] > maxLenght)
                {
                    maxLenght = lenght[x];
                    maxIndex = x;
                }
            }

            var result = new List<int>();
            while (maxIndex != -1)
            {
                result.Add(numbers[maxIndex]);
                maxIndex = preveous[maxIndex];
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
