namespace _05.UserLogins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogins
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var userData = new Dictionary<string, string>();

            while (input != "login")
            {
                var inputTokens = input
                    .Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string userName = inputTokens[0];
                string password = inputTokens[1];

                if (!userData.ContainsKey(userName))
                {
                    userData.Add(userName, string.Empty);
                }
                userData[userName] = password;

                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            int failedLogsCounter = 0;
            while (input != "end")
            {
                var inputTokens = input
                    .Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string userName = inputTokens[0];
                string password = inputTokens[1];
                if (userData.ContainsKey(userName) && userData[userName] == password)
                {
                    Console.WriteLine($"{userName}: logged in successfully");
                }
                else
                {
                    Console.WriteLine($"{userName}: login failed");
                    failedLogsCounter++;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {failedLogsCounter}");
        }
    }
}
