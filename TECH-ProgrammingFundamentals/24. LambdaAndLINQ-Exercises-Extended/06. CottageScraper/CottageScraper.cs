namespace _06.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CottageScraper
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var treeData = new List<KeyValuePair<string, int>>();

            while (input != "chop chop")
            {
                var inputTokens = input
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string sortOfTree = inputTokens[0];
                int height = int.Parse(inputTokens[1]);

                treeData.Add(new KeyValuePair<string, int>(sortOfTree, height));
                input = Console.ReadLine();
            }
            string lookingForAType = Console.ReadLine();
            int meters = int.Parse(Console.ReadLine());


            double pricePerMeter = Math.Round(treeData.Sum(x => x.Value) / (double)treeData.Count, 2);
            var usedLogs = treeData.Where(x => x.Value >= meters && x.Key == lookingForAType).Sum(x => x.Value);
            var unusedLogz = treeData.Where(x => x.Value < meters || x.Key != lookingForAType).Sum(x => x.Value);

            double usedLogsPrice = Math.Round(usedLogs * pricePerMeter, 2);
            double unusedLogs = Math.Round(unusedLogz * pricePerMeter * 0.25, 2);
            double total = Math.Round(usedLogsPrice + unusedLogs,2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogs:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${total:f2}");
        }
    }
}
