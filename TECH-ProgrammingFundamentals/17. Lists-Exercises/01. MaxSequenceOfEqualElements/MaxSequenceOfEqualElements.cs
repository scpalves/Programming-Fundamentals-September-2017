namespace Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Lists
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int lenght = 1;
            int bestEqual = numbers[0];
            int bestLenght = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    start = numbers[i + 1];
                    lenght++;
                }
                else
                {
                    start = numbers[i + 1];
                    lenght = 1;
                }
                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                    bestEqual = start;
                }
            }
            var equal = new List<int>();

            for (int i = 0; i < bestLenght; i++)
            {
                equal.Add(bestEqual);
            }

            Console.WriteLine(string.Join(" ", equal));
        }
    }
}