using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class MatchHexadecimalNumbers
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            string pattern = @"\b(0x)?[A-F0-9]+\b";

            var matches = Regex.Matches(numbers, pattern)
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ",matches));
        }
    }
}
