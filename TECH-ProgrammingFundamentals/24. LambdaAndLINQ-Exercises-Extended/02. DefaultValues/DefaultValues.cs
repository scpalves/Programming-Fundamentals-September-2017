namespace _02.DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValues
    {
        private static Dictionary<string, string> dict =
            new Dictionary<string, string>();
        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                var inputTokens = input
                    .Split(new[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string key = inputTokens[0];
                string value = inputTokens[1];
                AddToDict(key, value);
                input = Console.ReadLine();
            }

            string replaceWord = Console.ReadLine();
            var finalDict = new Dictionary<string, string>();

            foreach (var items in dict.OrderByDescending(x => x.Value.Length))
            {
                string currentWord = items.Key;
                if (dict[currentWord] == "null")
                {
                    if (!finalDict.ContainsKey(currentWord))
                    {
                        finalDict.Add(currentWord,String.Empty);
                    }
                    finalDict[currentWord] = replaceWord;
                }
                else
                {
                    Console.WriteLine($"{currentWord} <-> {items.Value}");
                }
            }

            foreach (var items in finalDict)
            {
                Console.WriteLine($"{items.Key} <-> {items.Value}");
            }
        }

        public static void AddToDict(string key, string value)
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, String.Empty);
            }
            dict[key] = value;
        }
    }
}
