namespace _04.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        static Dictionary<string, List<long>> shellhounds =
            new Dictionary<string, List<long>>();
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input!= "Aggregate")
            {
                var inputTokens = input
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string direction = inputTokens[0];
                long quantity = long.Parse(inputTokens[1]);

                AddToShellhoundsData(direction, quantity);
                input = Console.ReadLine();
            }

            PrintShellhoundsData();
        }

        public static void AddToShellhoundsData(string direction, long quantity)
        {
            if (!shellhounds.ContainsKey(direction))
            {
                shellhounds.Add(direction, new List<long>());
            }
            shellhounds[direction].Add(quantity);
        }

        public static void PrintShellhoundsData()
        {
            foreach (var shellhound in shellhounds)
            {
                string direction = shellhound.Key;
                var quantity = shellhound.Value.Distinct();
                long average = (long)quantity.Average();
                long sum = quantity.Sum();
                long finalResult = Math.Abs(average - sum);

                Console.WriteLine($"{direction} -> {string.Join(", ",quantity)} ({finalResult})");
            }
        }
    }
}
