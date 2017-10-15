namespace _03.MixedPhones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MixedPhones
    {
        static Dictionary<string, string> phonebook = new Dictionary<string, string>();
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "Over")
            {
                var inputTokens = input
                    .Split(" : ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string nameOrPhone = inputTokens[0];
                string nameOrPhoneSecond = inputTokens[1];

                if (IsLetter(nameOrPhone))
                {
                    AddToPhonebook(nameOrPhone, nameOrPhoneSecond);
                }
                else
                {
                    AddToPhonebook(nameOrPhoneSecond, nameOrPhone);
                }
                input = Console.ReadLine();
            }
            PrintPhonebook();
        }

        public static bool IsLetter(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLetter(word[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddToPhonebook(string name, string phone)
        {
            if (!phonebook.ContainsKey(name))
            {
                phonebook.Add(name, string.Empty);
            }
            phonebook[name] = phone;
        }

        public static void PrintPhonebook()
        {
            foreach (var phonebookData in phonebook.OrderBy(x => x.Key))
            {
                string user = phonebookData.Key;
                string phone = phonebookData.Value;
                Console.WriteLine($"{user} -> {long.Parse(phone)}");
            }
        }
    }
}
