namespace _04.SoftUniBeerPong
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniBeerPong
    {
        static Dictionary<string, Dictionary<string, int>> playersData = 
            new Dictionary<string, Dictionary<string, int>>();
        public static void Main()
        {
            string input = Console.ReadLine();
            

            while (input != "stop the game")
            {
                var inputTokens = input
                    .Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                string team = inputTokens[1];
                int points = int.Parse(inputTokens[2]);

                if (!playersData.ContainsKey(team))
                {
                    playersData.Add(team, new Dictionary<string, int>());
                }

                if (playersData[team].Count < 3)
                {
                    AddToPlayersData(team, name, points);
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }

                input = Console.ReadLine();
            }
            PrintPlayersData();
        }

        public static void AddToPlayersData(string team, string name, int points)
        {
            if (!playersData[team].ContainsKey(name))
            {
                playersData[team].Add(name, 0);
            }
            playersData[team][name] = points;
        }

        public static void PrintPlayersData()
        {
            int counter = 1;
            foreach (var player in playersData.Where(x => x.Value.Count == 3).OrderByDescending(x => x.Value.Values.Sum()))
            {
                string team = player.Key;
                Console.WriteLine($"{counter}. {team}; Players:");
                counter++;
                var playersAndScore = player.Value;
                foreach (var playerAndScore in playersAndScore.OrderByDescending(x => x.Value))
                {
                    string playerName = playerAndScore.Key;
                    int playerScore = playerAndScore.Value;
                    Console.WriteLine($"###{playerName}: {playerScore}");
                }
            }
        }
    }
}
