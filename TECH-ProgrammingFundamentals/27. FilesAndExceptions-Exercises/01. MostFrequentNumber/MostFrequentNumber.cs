namespace _01.MostFrequentNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            
            var input = File.ReadAllText("../../input.txt");
            File.Delete("../../output.txt");
            var stringToIntegers = input
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var mostFrequentNumber = new Dictionary<int, int>();

            foreach (var number in stringToIntegers)
            {
                if (!mostFrequentNumber.ContainsKey(number))
                {
                    mostFrequentNumber.Add(number, 0);
                }
                mostFrequentNumber[number]++;
            }

            foreach (var number in mostFrequentNumber
                .OrderByDescending(x => x.Value).Take(1))
            {
                var output = number.Key;
                File.AppendAllText("../../output.txt", output.ToString());
            }
        }
    }
}
