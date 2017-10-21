using System.Globalization;

namespace LambdaAndLINQ_Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RegisterUsers
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var saveUserData = new Dictionary<string, DateTime>();

            while (input != "end")
            {
                var inputTokens = input
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                var date = DateTime.ParseExact(inputTokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!saveUserData.ContainsKey(name))
                {
                    saveUserData.Add(name, new DateTime());
                }
                saveUserData[name] = date;
                input = Console.ReadLine();
            }

            if (saveUserData.Count < 5)
            {
                foreach (var name in saveUserData
                    .OrderBy(x => x.Value)
                    .ThenBy(x => x.Key)
                    .Reverse())
                {
                    Console.WriteLine(name.Key);
                }
            }
            else
            {
                foreach (var user in saveUserData
                    .OrderByDescending(x => x.Value)
                    .Reverse()
                    .Take(5)
                    .OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{user.Key}");
                }
            }
        }
    }
}
