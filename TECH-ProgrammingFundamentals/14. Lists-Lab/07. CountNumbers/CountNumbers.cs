namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var countingNumbers = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (countingNumbers.ContainsKey(number))
                {
                    countingNumbers[number]++;
                }
                else
                {
                    countingNumbers.Add(number, 1);
                }
            }

            foreach (var number in countingNumbers.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
