namespace _06.UserLogs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        private static Dictionary<string, Dictionary<string, int>> userLogsData =
            new Dictionary<string, Dictionary<string, int>>();

        public static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                var inputTokens = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var ip = inputTokens[0].Split('=').Last();
                string user = inputTokens[2].Split('=').Last();

                AddToUserLogsData(ip, user);

                input = Console.ReadLine();
            }

            PrintUserLogsData();
        }

        public static void AddToUserLogsData(string ip, string user)
        {
            if (!userLogsData.ContainsKey(user))
            {
                userLogsData.Add(user, new Dictionary<string, int>());
            }
            if (!userLogsData[user].ContainsKey(ip))
            {
                userLogsData[user].Add(ip, 1);
            }
            else
            {
                userLogsData[user][ip]++;
            }

        }

        public static void PrintUserLogsData()
        {
            foreach (var userLogs in userLogsData.OrderBy(x => x.Key))
            {
                int logsCount = 0;
                string userName = userLogs.Key;
                var userIpAndLogs = userLogs.Value;

                Console.WriteLine($"{userName}: ");

                foreach (var user in userIpAndLogs)
                {
                    logsCount++;
                    int last = userLogs.Value.Count;
                    string ip = user.Key;
                    int countOfLogs = user.Value;

                    if (logsCount == last)
                    {
                        Console.Write($"{ip} => {countOfLogs}.");
                    }
                    else
                    {
                        Console.Write($"{ip} => {countOfLogs}, ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
