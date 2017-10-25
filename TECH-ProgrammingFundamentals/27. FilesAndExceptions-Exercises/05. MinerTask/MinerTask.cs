namespace _05.MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MinerTask
    {
        public static void Main()
        {
            var line = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            var minerData = new Dictionary<string, long>();

            for (int i = 0; i < line.Length; i += 2)
            {
                if (line[i] == "stop" || line[i + 1] == "stop")
                {
                    break;
                }

                string resource = line[i];
                int quantity = int.Parse(line[i + 1]);

                if (!minerData.ContainsKey(resource))
                {
                    minerData.Add(resource, 0);
                }
                minerData[resource] += quantity;
            }

            foreach (var items in minerData)
            {
                string resource = items.Key;
                long quantity = items.Value;
                string output = $"{resource} -> {quantity} {Environment.NewLine}";
                File.AppendAllText("output.txt", output);
            }
        }
    }
}
