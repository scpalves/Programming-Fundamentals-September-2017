namespace _05.DictRefAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRefAdvanced
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var dict = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                var inputTokens = input
                    .Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];

                if (!IsLetter(inputTokens[1]))
                {
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, new List<int>());
                    }
                    var numbers = inputTokens[1]
                        .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();
                    dict[name].AddRange(numbers);
                }
                else
                {
                    if (dict.ContainsKey(inputTokens[1]))
                    {
                        var newValue = dict[inputTokens[1]];
                        if (!dict.ContainsKey(name))
                        {
                            dict.Add(name, new List<int>());
                        }
                        dict[name].AddRange(newValue);
                    }
                }


                input = Console.ReadLine();
            }

            foreach (var items in dict)
            {
                string name = items.Key;
                var values = items.Value;

                Console.WriteLine($"{name} === {string.Join(", ",values)}");
            }
        }

        public static bool IsLetter(string input)
        {
            if (input.All(x => char.IsLetter(x)))
            {
                return true;
            }
            return false;
        }
    }
}
