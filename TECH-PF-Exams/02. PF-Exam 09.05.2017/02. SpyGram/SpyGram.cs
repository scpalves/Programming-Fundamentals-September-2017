namespace _02.SpyGram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SpyGram
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            var outputData = new List<KeyValuePair<string, string>>();


            while (input != "END")
            {
                var inputTokens = input
                    .Split(new string[] { ": ", "; " }, StringSplitOptions.RemoveEmptyEntries);

                string to = inputTokens[0];
                string recepient = inputTokens[1];

                if (to != "TO")
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!recepient.All(ch => char.IsUpper(ch) && char.IsLetter(ch)))
                {
                    input = Console.ReadLine();
                    continue;
                }

                StringBuilder switchingLetters = new StringBuilder();
                
                string encrypted = SwitchingLetters(input, key, switchingLetters);
                

                outputData.Add(new KeyValuePair<string, string>(recepient, encrypted));
                input = Console.ReadLine();
            }

            foreach (var info in outputData
                .OrderBy(x => x.Key))
            {
                Console.WriteLine($"{info.Value}");
            }
        }

        public static string SwitchingLetters(string word, string key, StringBuilder finalMessage)
        {
            int keyLenghtCounter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                finalMessage.Append((char)(word[i] + int.Parse(key[keyLenghtCounter].ToString())));
                keyLenghtCounter++;

                if (keyLenghtCounter == key.Length)
                {
                    keyLenghtCounter = 0;
                }
            }

            return finalMessage.ToString();
        }
    }
}
