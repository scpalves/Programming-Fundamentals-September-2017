namespace _03.MinMaxSumAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMaxSumAverage
    {
        public static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            var result = new List<int>();

            for (int i = 0; i < countOfNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                result.Add(currentNumber);
            }

            int sum, min, max;
            double average;

            SimpleMathTests(result, out sum, out min, out max, out average);
            PrintingResultAfterSimpleMathTests(sum, min, max, average);
        }

        private static void SimpleMathTests(List<int> result, out int sum, out int min, out int max, out double average)
        {
            sum = result.Sum();
            min = result.Min();
            max = result.Max();
            average = result.Average();
        }

        private static void PrintingResultAfterSimpleMathTests(int sum, int min, int max, double average)
        {
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Average: {average}");
        }
    }
}
