namespace _02.OddFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddFilter
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToList();

            double averageValue = numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= averageValue)
                {
                    numbers[i] -= 1;
                }
                else
                {
                    numbers[i] += 1;
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
