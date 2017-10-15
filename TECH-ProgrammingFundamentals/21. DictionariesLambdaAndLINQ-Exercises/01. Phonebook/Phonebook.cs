namespace DictionariesLambdaAndLINQ_Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        static Dictionary<string, string> phonebookData = new Dictionary<string, string>();

        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                var inputTokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var command = inputTokens[0];
                string name = inputTokens[1];

                if (command == "A")
                {
                    string phone = inputTokens[2];
                    AddToPhonebook(name, phone);
                }
                else
                {
                    PrintPhonebook(name);
                }
                input = Console.ReadLine();
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
