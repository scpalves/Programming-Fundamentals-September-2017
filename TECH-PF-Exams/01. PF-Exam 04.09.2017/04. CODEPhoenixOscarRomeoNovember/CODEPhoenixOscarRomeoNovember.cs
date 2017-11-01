namespace _04.CODEPhoenixOscarRomeoNovember
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CODEPhoenixOscarRomeoNovember
    {
        public static void Main()
        {
            var creaturesData = new Dictionary<string, HashSet<string>>();
            var input = Console.ReadLine();
            while (input != "Blaze it!")
            {
                var inputLine = input
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string creatureName = inputLine[0];
                string squadMateName = inputLine[1];

                if (creatureName == squadMateName)
                {
                    input = Console.ReadLine();
                    continue;
                }

                AddToCreaturesData(creaturesData, creatureName, squadMateName);

                input = Console.ReadLine();
            }
            var finalCreaturesData = new Dictionary<string, HashSet<string>>();

            FilteringCreaturesAndSquadMatesForEqualNames(creaturesData, finalCreaturesData);

            PrintFilteredCreaturesData(finalCreaturesData);
        }

        private static void PrintFilteredCreaturesData(Dictionary<string, HashSet<string>> finalCreaturesData)
        {
            foreach (var creatures in finalCreaturesData
                            .OrderByDescending(x => x.Value.Count))
            {
                string creaturname = creatures.Key;
                long creaturesCount = creatures.Value.Count;

                Console.WriteLine($"{creaturname} : {creaturesCount}");
            }
        }

        private static void FilteringCreaturesAndSquadMatesForEqualNames(Dictionary<string, HashSet<string>> creaturesData, Dictionary<string, HashSet<string>> finalCreaturesData)
        {
            foreach (var creatures in creaturesData)
            {
                string creatureName = creatures.Key;
                finalCreaturesData.Add(creatureName, new HashSet<string>());

                foreach (var names in creatures.Value)
                {
                    if (creaturesData.ContainsKey(names) && creaturesData[names].Contains(creatureName))
                    {
                        continue;
                    }
                    else
                    {
                        finalCreaturesData[creatureName].Add(names);
                    }
                }
            }
        }

        public static void AddToCreaturesData(Dictionary<string, HashSet<string>> creatureData, string creatureName,
            string squadMateName)
        {
            if (!creatureData.ContainsKey(creatureName))
            {
                creatureData.Add(creatureName, new HashSet<string>());
            }
            creatureData[creatureName].Add(squadMateName);
        }
    }
}
