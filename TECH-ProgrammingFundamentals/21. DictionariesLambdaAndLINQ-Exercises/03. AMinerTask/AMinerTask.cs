namespace _03.AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AMinerTask
    {
        static Dictionary<string, int> minerData = new Dictionary<string, int>();
        public static void Main()
        {
            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                AddToMinerData(resource, quantity);

                resource = Console.ReadLine();
            }

            PrintMinerData();
        }

        public static void AddToMinerData(string resource, int quantity)
        {
            if (!minerData.ContainsKey(resource))
            {
                minerData.Add(resource, 0);
            }
            minerData[resource] += quantity;
        }

        public static void PrintMinerData()
        {
            foreach (var miner in minerData)
            {
                string resource = miner.Key;
                int quantity = miner.Value;

                Console.WriteLine($"{resource} -> {quantity}");
            }
        }
    }
}
