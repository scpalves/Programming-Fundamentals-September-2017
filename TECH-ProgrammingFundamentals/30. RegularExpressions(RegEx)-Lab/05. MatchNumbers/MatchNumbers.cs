using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MatchNumbers
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var matches = Regex.Matches(numbers, pattern)
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(" ",matches));
        }
    }
}
