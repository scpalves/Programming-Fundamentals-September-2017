namespace _09.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        static Dictionary<string, long> farmingData = new Dictionary<string, long>();
        static Dictionary<string, long> junksData = new Dictionary<string, long>();

        public static void Main()
        {
            farmingData.Add("shards", 0);
            farmingData.Add("fragments", 0);
            farmingData.Add("motes", 0);
            int countOfInputs = 1;

            var inputTokens = Console.ReadLine()
                .ToLower()
                .Split()
                .ToList();

            while (countOfInputs != 10)
            {
                long quantity = 0;
                string material = string.Empty;

                for (int i = 0; i < inputTokens.Count; i++)
                {
                    var isMaterialFilled = false;
                    if (i % 2 == 0)
                    {
                        quantity = long.Parse(inputTokens[i]);
                        isMaterialFilled = false;
                    }
                    else
                    {
                        material = inputTokens[i];
                        isMaterialFilled = true;
                    }


                    if (isMaterialFilled)
                    {

                        if (material == "shards")
                        {
                            farmingData["shards"] += quantity;
                        }
                        else if (material == "motes")
                        {
                            farmingData["motes"] += quantity;
                        }
                        else if (material == "fragments")
                        {
                            farmingData["fragments"] += quantity;
                        }
                        else
                        {
                            AddToJunkData(quantity, material);
                        }
                    }

                    if (CheckingForObtainedItemAndPrintingRestOfTheItems())
                    {
                        return;
                    }
                }
                countOfInputs++;
                inputTokens = Console.ReadLine()
                    .ToLower()
                    .Split()
                    .ToList();

            }
        }

        private static bool CheckingForObtainedItemAndPrintingRestOfTheItems()
        {
            if (farmingData.ContainsKey("fragments") && farmingData["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                farmingData["fragments"] -= 250;
                PrintFarmingData();
                return true;
            }
            if (farmingData.ContainsKey("shards") && farmingData["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                farmingData["shards"] -= 250;
                PrintFarmingData();
                return true;
            }
            if (farmingData.ContainsKey("motes") && farmingData["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                farmingData["motes"] -= 250;
                PrintFarmingData();
                return true;
            }
            return false;
        }

        public static void AddToJunkData(long quantity, string material)
        {
            if (!junksData.ContainsKey(material))
            {
                junksData.Add(material, 0);
            }
            junksData[material] += quantity;
        }

        public static void PrintFarmingData()
        {
            foreach (var items in farmingData.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                var item = items.Key;
                long quantity = items.Value;
                Console.WriteLine($"{item}: {quantity}");
            }
            foreach (var items in junksData.OrderBy(x => x.Key))
            {
                string item = items.Key;
                long quantity = items.Value;
                Console.WriteLine($"{item}: {quantity}");
            }
        }
    }
}
