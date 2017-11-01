namespace _04.NSA
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NSA
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var soldiersData = new Dictionary<string, Dictionary<string, long>>();

            while (input != "quit")
            {
                var inputTokens = input
                    .Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);

                string country = inputTokens[0];
                string soldier = inputTokens[1];
                long daysInServices = long.Parse(inputTokens[2]);

                AddToSoldiersData(soldiersData, country, soldier, daysInServices);

                input = Console.ReadLine();
            }

            PrintSoldiersData(soldiersData);
        }

        public static void PrintSoldiersData(Dictionary<string, Dictionary<string, long>>soldiersData)
        {
            foreach (var countriesAndSoldiersData in soldiersData
                .OrderByDescending(x => x.Value.Values.Count))
            {
                string country = countriesAndSoldiersData.Key;
                var soldersData = countriesAndSoldiersData.Value;

                Console.WriteLine($"Country: {country}");

                foreach (var soldiersAndDays in soldersData
                    .OrderByDescending(x => x.Value))
                {
                    string soldierName = soldiersAndDays.Key;
                    long days = soldiersAndDays.Value;
                    Console.WriteLine($"**{soldierName} : {days}");
                }
            }
        }

        public static void AddToSoldiersData(Dictionary<string, Dictionary<string, long>> soldiersData,
            string country, string solder, long daysInServices)
        {
            if (!soldiersData.ContainsKey(country))
            {
                soldiersData.Add(country, new Dictionary<string, long>());
            }
            if (!soldiersData[country].ContainsKey(solder))
            {
                soldiersData[country].Add(solder, 0);
            }
            soldiersData[country][solder] = daysInServices;
        }
    }
}
 