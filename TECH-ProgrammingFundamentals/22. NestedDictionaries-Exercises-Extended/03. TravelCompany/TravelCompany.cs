namespace _03.TravelCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TravelCompany
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var travelData = new Dictionary<string, Dictionary<string, int>>();

            while (input != "ready")
            {
                var inputTokens = input
                    .Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                string city = inputTokens[0];
                var veicheleAndSeats = inputTokens[1]
                    .Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int i = 0; i < veicheleAndSeats.Count; i += 2)
                {
                    string transport = veicheleAndSeats[i];
                    int seats = int.Parse(veicheleAndSeats[i + 1]);

                    AddingToTravelData(travelData, city, transport, seats);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "travel time!")
            {
                var inputTokens = input
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string city = inputTokens[0];
                int seats = int.Parse(inputTokens[1]);
                int diff = travelData[city].Values.Sum();

                CheckingCapacity(travelData, city, seats, diff);

                input = Console.ReadLine();
            }
        }

        private static void AddingToTravelData(Dictionary<string, Dictionary<string, int>> travelData, string city, string transport, int seats)
        {
            if (!travelData.ContainsKey(city))
            {
                travelData.Add(city, new Dictionary<string, int>());
            }
            if (!travelData[city].ContainsKey(transport))
            {
                travelData[city].Add(transport, 0);
            }
            travelData[city][transport] = seats;
        }

        private static void CheckingCapacity(Dictionary<string, Dictionary<string, int>> travelData, string city, int seats, int diff)
        {
            if (travelData[city].Values.Sum() >= seats)
            {
                Console.WriteLine($"{city} -> all {seats} accommodated");
            }
            else if (travelData[city].Values.Sum() < seats)
            {
                Console.WriteLine($"{city} -> all except {seats - diff} accommodated");
            }
        }
    }
}
