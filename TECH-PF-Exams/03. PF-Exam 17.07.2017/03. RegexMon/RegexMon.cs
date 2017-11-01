namespace _03.RegexMon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class RegexMon
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string didimon = @"(?<didimon>[^a-zA-Z\-]+)";
            string bojomon = @"(?<bojomon>[a-zA-Z]+\-[a-zA-Z]+)";
            int playersTurn = 0;
            bool isMatch = true;

            while (isMatch != false)
            {
                if (playersTurn % 2 == 0)
                {
                    DidimonMatches(ref input, didimon, ref isMatch);
                }
                else if (playersTurn % 2 == 1)
                {
                    BojomonMatches(ref input, bojomon, ref isMatch);
                }
                playersTurn++;
            }
        }

        private static void DidimonMatches(ref string input, string didimon, ref bool isMatch)
        {
            var didimonMatch = Regex.Match(input, didimon);

            if (didimonMatch.Success)
            {
                string matchedValue = didimonMatch.Value;
                Console.WriteLine(matchedValue);
                int firstIndexOfMatch = input.IndexOf(matchedValue);
                input = input.Remove(0, firstIndexOfMatch + matchedValue.Length);
            }
            else
            {
                isMatch = false;
            }
        }

        private static void BojomonMatches(ref string input, string bojomon, ref bool isMatch)
        {
            var bojomonMatch = Regex.Match(input, bojomon);

            if (bojomonMatch.Success)
            {
                string matchedValue = bojomonMatch.Value;
                Console.WriteLine(matchedValue);
                int firstIndexOfMatch = input.IndexOf(matchedValue);
                input = input.Remove(0, firstIndexOfMatch + matchedValue.Length);
            }
            else
            {
                isMatch = false;
            }
        }
    }
}
