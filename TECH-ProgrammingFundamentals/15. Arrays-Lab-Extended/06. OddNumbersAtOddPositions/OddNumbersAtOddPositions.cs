namespace _06.OddNumbersAtOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currnetNumber = numbers[i];
                if (i % 2 != 0 && currnetNumber % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {currnetNumber}");
                }
            }
        }
    }
}
