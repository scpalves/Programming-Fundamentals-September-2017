using System.Text;
using System.Text.RegularExpressions;

namespace _02.WormIpsum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WormIpsum
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"^^[A-Z][^\.]*?\.$";
            var charsData = new Dictionary<char, int>();
            StringBuilder finalSenteces = new StringBuilder();
            
            int sentenceCounter = 0;

            while (input != "Worm Ipsum")
            {
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    var currentSentece = match.Groups[0].Value
                        .Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var words in currentSentece)
                    {
                        
                        bool isRepeating = false;
                        for (int i = 0; i < words.Length; i++)
                        {
                            char currentChar = words[i];
                            if (!charsData.ContainsKey(currentChar))
                            {
                                charsData.Add(currentChar, 0);
                            }
                            charsData[currentChar]++;
                        }

                        foreach (var charsAndCounts in charsData
                            .OrderByDescending(x => x.Value))
                        {
                            char letter = charsAndCounts.Key;
                            int repeatingTimes = charsAndCounts.Value;

                            if (repeatingTimes > 1)
                            {
                                finalSenteces.Append(new string(letter, words.Length) + ' ');
                                isRepeating = true;
                                break;
                            }
                            break;
                        }

                        if (!isRepeating)
                        {
                            finalSenteces.Append(words + ' ');
                        }
                        sentenceCounter++;

                        if (sentenceCounter == currentSentece.Length)
                        {
                            var str = finalSenteces.ToString().TrimEnd(' ') + '.';
                            sentenceCounter = 0;
                            finalSenteces.Clear();
                            Console.WriteLine(str);
                        }

                        charsData.Clear();
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
