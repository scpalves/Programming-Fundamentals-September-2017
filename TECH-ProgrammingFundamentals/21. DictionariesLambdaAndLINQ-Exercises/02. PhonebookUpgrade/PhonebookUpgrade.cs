namespace DictionariesLambdaAndLINQ_Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhonebookUpgrade
    {
        static SortedDictionary<string, string> phonebookData = new SortedDictionary<string, string>();

        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                var inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = inputTokens[0];

                if (command == "A")
                {
                    string name = inputTokens[1];
                    string phone = inputTokens[2];
                    AddToPhonebook(name, phone);
                }
                else if (command == "S")
                {
                    string name = inputTokens[1];
                    PrintPhonebook(name);
                }
                else 
                {
                    PrintAllDataFromPhonebook();
                }

                input = Console.ReadLine();
            }
        }

        public static void PrintAllDataFromPhonebook()
        {
            foreach (var user in phonebookData)
            {
                string name = user.Key;
                string phone = user.Value;

                Console.WriteLine($"{name} -> {phone}");
            }
        }

        public static void PrintPhonebook(string name)
        {
            if (phonebookData.ContainsKey(name))
            {
                Console.WriteLine($"{name} -> {phonebookData[name]}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

        public static void AddToPhonebook(string name, string phone)
        {
            if (!phonebookData.ContainsKey(name))
            {
                phonebookData.Add(name, string.Empty);
            }
            phonebookData[name] = phone;
        }
    }
}
