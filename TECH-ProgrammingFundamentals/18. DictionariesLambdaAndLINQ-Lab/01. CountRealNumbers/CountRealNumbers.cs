namespace DictionariesLambdaAndLINQ_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            var countRealNumbers = new SortedDictionary<double, int>();

            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            foreach (var number in numbers)
            {
                if (!countRealNumbers.ContainsKey(number))
                {
                    countRealNumbers.Add(number, 0);
                }
                countRealNumbers[number]++;
            }

            foreach (var countRealNumber in countRealNumbers)
            {
                var realNumbers = countRealNumber.Key;
                var count = countRealNumber.Value;

                Console.WriteLine($"{realNumbers} -> {count}");
            }
        }
    }
}
