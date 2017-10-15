namespace _10.СръбскоUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class СръбскоUnleashed
    {
        
        public static void Main()
        {

            string input = Console.ReadLine();
            var singersInfo = new Dictionary<string, Dictionary<string, decimal>>();
            int inputCounter = 1;

            while (input != "End" || inputCounter != 50)
            {
                var inputTokens = input
                    .Split("@".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

                string name = inputTokens[0].TrimEnd();
                var placeAndTickets = inputTokens[1]
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string place = string.Empty;
                decimal price = 0m;
                long tickets = 0;

                if (placeAndTickets.Length == 3)
                {
                    place = placeAndTickets[0];
                    price = decimal.Parse(placeAndTickets[1]);
                    tickets = long.Parse(placeAndTickets[2]);
                }
                else if (placeAndTickets.Length == 4)
                {
                    place = placeAndTickets[0] + " " + placeAndTickets[1];
                    price = decimal.Parse(placeAndTickets[2]);
                    tickets = long.Parse(placeAndTickets[3]);
                }
                else if (placeAndTickets.Length == 5)
                {
                    place = placeAndTickets[0] + " " + placeAndTickets[1] + " " + placeAndTickets[2];
                    price = decimal.Parse(placeAndTickets[3]);
                    tickets = long.Parse(placeAndTickets[4]);
                }
                else
                {
                    inputCounter++;
                    input = Console.ReadLine();
                    continue;
                }

                if (!singersInfo.ContainsKey(place))
                {
                    singersInfo.Add(place, new Dictionary<string, decimal>());
                }
                if (!singersInfo[place].ContainsKey(name))
                {
                    singersInfo[place].Add(name, 0);
                }
                singersInfo[place][name] += price * tickets;

                inputCounter++;
                input = Console.ReadLine();
            }

            foreach (var info in singersInfo)
            {
                string place = info.Key;
                var singersAndMoney = info.Value;
                Console.WriteLine(place);

                foreach (var singerAndMoney in singersAndMoney.OrderByDescending(x => x.Value))
                {
                    string singer = singerAndMoney.Key;
                    decimal money = singerAndMoney.Value;

                    Console.WriteLine($"#  {singer} -> {money}");
                }
            }
        }
    }
}
