namespace _07.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        static Dictionary<string, Dictionary<string, long>> populationData =
            new Dictionary<string, Dictionary<string, long>>();

        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "report")
            {
                var inputTokens = input.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string city = inputTokens[0];
                string country = inputTokens[1];
                long population = long.Parse(inputTokens[2]);

                AddToPopulationData(country, city, population);

                input = Console.ReadLine();
            }

            PrintPopulationData();
        }

        public static void AddToPopulationData(string country, string city, long population)
        {
            if (!populationData.ContainsKey(country))
            {
                populationData.Add(country, new Dictionary<string, long>());
            }
            if (!populationData[country].ContainsKey(city))
            {
                populationData[country].Add(city, population);
            }
        }

        public static void PrintPopulationData()
        {
            foreach (var data in populationData.OrderByDescending(x => x.Value.Values.Sum()))
            {
                string country = data.Key;
                var cityAndPopulation = data.Value;
                long totalPopulation = cityAndPopulation.Values.Sum();
                Console.WriteLine($"{country} (total population: {totalPopulation})");

                foreach (var cityAndPeople in cityAndPopulation.OrderByDescending(x => x.Value))
                {
                    string city = cityAndPeople.Key;
                    long population = cityAndPeople.Value;

                    Console.WriteLine($"=>{city}: {population}");
                }
            }
        }
    }
}
