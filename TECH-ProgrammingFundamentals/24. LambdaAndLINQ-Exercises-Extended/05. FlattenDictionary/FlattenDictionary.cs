namespace _05.FlattenDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlattenDictionary
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, Dictionary<string, string>>();
            var flattenDict = new Dictionary<string, List<string>>();
            while (input != "end")
            {
                var inputTokens = input
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string flatterOrNot = inputTokens[0];

                if (flatterOrNot == "flatten")
                {
                    string neededKey = inputTokens[1];

                    foreach (var items in dict)
                    {
                        string key = items.Key;
                        var flattenValue = items.Value;
                        if (key == neededKey)
                        {

                        }
                        string newValue = string.Empty;
                        foreach (var item in flattenValue)
                        {
                            string leftPart = item.Key;
                            var rightPart = item.Value;
                            newValue = leftPart + rightPart;

                            if (!flattenDict.ContainsKey(neededKey))
                            {
                                flattenDict.Add(neededKey, new List<string>());
                            }
                            flattenDict[neededKey].Add(newValue);
                        }
                    }
                    dict[neededKey] = new Dictionary<string, string>();
                }
                else
                {
                    string innerKey = inputTokens[1];
                    string innerValue = inputTokens[2];
                    if (!dict.ContainsKey(flatterOrNot))
                    {
                        dict.Add(flatterOrNot, new Dictionary<string, string>());
                    }
                    dict[flatterOrNot][innerKey] = innerValue;
                }
                input = Console.ReadLine();
            }

            foreach (var items in dict)
            {
                int itemsCounter = 1;
                string category = items.Key;
                var notFlatItems = items.Value;
                Console.WriteLine($"{category}");
                foreach (var notFlatten in notFlatItems)
                {
                    string innerKey = notFlatten.Key;
                    string innerValue = notFlatten.Value;
                    Console.WriteLine($"{itemsCounter}. {innerKey} - {innerValue}");
                    itemsCounter++;
                }
                if (flattenDict.ContainsKey(category))
                {
                    foreach (var flattData in flattenDict[category])
                    {
                        Console.WriteLine($"{itemsCounter}. {flattData}");
                        itemsCounter++;
                    }
                }
            }
        }
    }
}
