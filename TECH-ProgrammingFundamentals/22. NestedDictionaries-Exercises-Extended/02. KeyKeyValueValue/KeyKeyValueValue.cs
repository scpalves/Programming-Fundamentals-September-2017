namespace _02.KeyKeyValueValue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KeyKeyValueValue
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string value = Console.ReadLine();
            var dict = new Dictionary<string, List<string>>();
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                var inputTokens = Console.ReadLine()
                    .Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                string innerKey = inputTokens[0];
                var innerValues = inputTokens[1].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (innerKey.Contains(key))
                {
                    if (!dict.ContainsKey(innerKey))
                    {
                        dict.Add(innerKey, new List<string>());
                    }
                    foreach (var innerValue in innerValues)
                    {
                        if (innerValue.Contains(value))
                        {
                            dict[innerKey].Add(innerValue);
                        }
                    }
                }
                
            }

            foreach (var items in dict)
            {
                string keys = items.Key;
                var values = items.Value.Select(x => "-" + x).ToList();
                Console.WriteLine($"{keys}:");
                foreach (var valuez in values)
                {
                    Console.WriteLine(valuez);
                }
            }
        }
    }
}
