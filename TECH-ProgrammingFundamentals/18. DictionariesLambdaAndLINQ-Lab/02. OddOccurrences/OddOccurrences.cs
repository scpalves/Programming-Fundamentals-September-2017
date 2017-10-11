namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var wordsData = new Dictionary<string, int>();

            var words = Console.ReadLine()
                .ToLower()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (!wordsData.ContainsKey(word))
                {
                    wordsData.Add(word, 0);
                }
                wordsData[word]++;
            }

            var oddOccurencesWordOnly = new List<string>();

            foreach (var wordData in wordsData)
            {
                string word = wordData.Key;
                int occurences = wordData.Value;
                

                if (occurences % 2 != 0)
                {
                    oddOccurencesWordOnly.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ",oddOccurencesWordOnly));
        }
    }
}
