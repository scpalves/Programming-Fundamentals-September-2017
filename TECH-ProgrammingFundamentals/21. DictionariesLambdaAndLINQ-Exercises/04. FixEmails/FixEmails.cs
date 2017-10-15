namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmails
    {
        static Dictionary<string, string> emailData = new Dictionary<string, string>();

        public static void Main()
        {
            string name = Console.ReadLine();

            while (name != "stop")
            {
                string email = Console.ReadLine();
                AddToEmailData(name, email);

                name = Console.ReadLine();
            }
            PrintEmailData();
        }

        public static void PrintEmailData()
        {
            foreach (var token in emailData)
            {
                string user = token.Key;
                string email = token.Value;

                if (email.EndsWith("bg"))
                {
                    Console.WriteLine($"{user} -> {email}");
                }
            }
        }

        public static void AddToEmailData(string name, string email)
        {
            if (!emailData.ContainsKey(name))
            {
                emailData.Add(name, email);
            }
        }
    }
}
