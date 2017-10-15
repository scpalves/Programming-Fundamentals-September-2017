using System.CodeDom;

namespace _02.Dict_Ref
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRef
    {
        static Dictionary<string, int> dict = new Dictionary<string, int>();

        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                var inputTokens = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string entry = inputTokens[0];
                var value = inputTokens[2];
                int result;
                if (int.TryParse(value, out result))
                {
                    AddToDictData(entry, result);
                }
                else
                {
                    if (dict.ContainsKey(value))
                    {
                        int newValue = dict[value];
                        AddToDictData(entry, newValue);
                    }
                }
                input = Console.ReadLine();
            }
            PrintDictData();
        }

        private static void AddToDictData(string entry, int result)
        {
            if (!dict.ContainsKey(entry))
            {
                dict.Add(entry, 0);
            }
            dict[entry] = result;
        }

        public static void PrintDictData()
        {
            foreach (var data in dict)
            {
                string key = data.Key;
                int value = data.Value;

                Console.WriteLine($"{key} === {value}");
            }
        }
    }
}
