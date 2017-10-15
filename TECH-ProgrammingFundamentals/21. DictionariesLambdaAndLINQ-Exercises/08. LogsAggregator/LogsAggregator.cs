namespace _08.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        static Dictionary<string, Dictionary<string, long>> logsAggregatorData =
            new Dictionary<string, Dictionary<string, long>>();
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                var inputTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string ip = inputTokens[0];
                string user = inputTokens[1];
                long time = long.Parse(inputTokens[2]);

                AddToLogsAggregatorData(ip, user, time);
            }
            PrintLogsAggregatorData();
        }

        public static void AddToLogsAggregatorData(string ip, string user, long time)
        {
            if (!logsAggregatorData.ContainsKey(user))
            {
                logsAggregatorData.Add(user, new Dictionary<string, long>());
            }
            if (!logsAggregatorData[user].ContainsKey(ip))
            {
                logsAggregatorData[user].Add(ip, 0);
            }
            logsAggregatorData[user][ip] += time;
        }

        public static void PrintLogsAggregatorData()
        {
            foreach (var userInfo in logsAggregatorData.OrderBy(x => x.Key))
            {
                string userName = userInfo.Key;
                var ipAndTime = userInfo.Value;
                long totalTime = ipAndTime.Values.Sum();
                int counter = 0;

                Console.Write($"{userName}: {totalTime} [");

                foreach (var userIpAndTime in ipAndTime.OrderBy(x => x.Key))
                {
                    counter++;
                    var ip = userIpAndTime.Key;
                    Console.Write($"{ip}");

                    if (counter < ipAndTime.Count)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.Write("]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
