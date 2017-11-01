namespace _04.WormsWorldParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WormsWorldParty
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var wormData = new Dictionary<string, Dictionary<string, long>>();
            var saveNames = new HashSet<string>();

            while (input != "quit")
            {
                var inputTokens = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string wormName = inputTokens[0];
                string teamName = inputTokens[1];
                long wormScore = long.Parse(inputTokens[2]);

                AddToWormData(saveNames, wormData, teamName, wormName, wormScore);

                input = Console.ReadLine();
            }

            PrintWormData(wormData);
        }

        public static void PrintWormData(Dictionary<string, Dictionary<string, long>> wormData)
        {
            int placeCounter = 1;
            foreach (var teamsAndWorms in wormData
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(x => x.Value.Values.Sum() / x.Value.Values.Count))
            {
                
                Console.WriteLine($"{placeCounter}. Team: {teamsAndWorms.Key} - {teamsAndWorms.Value.Values.Sum()}");
                placeCounter++;

                foreach (var wormsAndScore in teamsAndWorms.Value
                    .OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wormsAndScore.Key} : {wormsAndScore.Value}");
                }
            }
        }

        public static void AddToWormData(HashSet<string> saveNames, Dictionary<string, Dictionary<string, long>> wormData,
            string teamName, string wormName, long wormScore)
        {
            if (!saveNames.Contains(wormName))
            {
                if (!wormData.ContainsKey(teamName))
                {
                    wormData.Add(teamName, new Dictionary<string, long>());
                }
                if (!wormData[teamName].ContainsKey(wormName))
                {
                    wormData[teamName].Add(wormName, 0);
                }
                wormData[teamName][wormName] = wormScore;

                saveNames.Add(wormName);
            }
        }
    }
}
