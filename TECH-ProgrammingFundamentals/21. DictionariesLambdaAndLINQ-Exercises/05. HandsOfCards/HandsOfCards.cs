namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var playerData = new Dictionary<string, List<int>>();
            var input = Console.ReadLine();

            while (input != "JOKER")
            {
                var inputTokens = input.Split(':');
                var name = inputTokens[0];
                var cards = inputTokens[1]
                    .Split(", ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
                    .Select(GetCardValue)
                    .ToArray();

                if (!playerData.ContainsKey(name))
                {
                    playerData.Add(name, new List<int>());
                }
                playerData[name].AddRange(cards);

                input = Console.ReadLine();
            }

            foreach (var player in playerData)
            {
                var playerName = player.Key;
                var points = player.Value.Distinct().Sum();

                Console.WriteLine($"{playerName}: {points}");
            }
        }

        public static int GetCardValue(string card)
        {
            var cardPowers = new Dictionary<string, int>();
            cardPowers["J"] = 11;
            cardPowers["Q"] = 12;
            cardPowers["K"] = 13;
            cardPowers["A"] = 14;

            for (int i = 2; i <= 10; i++)
            {
                cardPowers[i.ToString()] = i;
            }

            var cardTypes = new Dictionary<string, int>();
            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            var power = card.Substring(0, card.Length - 1);
            var type = card.Substring(card.Length - 1);

            var value = cardPowers[power] * cardTypes[type];

            return value;
        }
    }
}
