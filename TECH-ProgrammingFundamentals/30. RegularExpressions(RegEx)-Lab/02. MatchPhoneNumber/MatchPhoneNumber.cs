using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string phoneNumbers = Console.ReadLine();
            string pattern = @"\+359([ |-])?2\1\d{3}\1\d{4}\b";

            var matches = Regex.Matches(phoneNumbers, pattern)
                .Cast<Match>()
                .Select(match => match.Value.Trim())
                .ToArray();
            
            Console.WriteLine(string.Join(", ",matches));
        }
    }
}
