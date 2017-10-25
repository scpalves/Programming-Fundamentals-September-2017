namespace _06.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var emails = new Dictionary<string, string>();
            var input = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");
            for (var i = 0; i < input.Length; i += 2)
            {
                var name = input[i];
                if (name == "stop")
                    break;
                string email = input[i + 1];
                if (email.ToLower().EndsWith("us") ||
                    email.ToLower().EndsWith("uk"))
                    continue;
                emails[name] = email;
            }
            var output = emails
                .Select(email => $"{email.Key} -> {email.Value}")
                .ToList();
            File.WriteAllLines("../../output.txt", output);
        }
    }
}
