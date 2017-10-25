using System.Text.RegularExpressions;

namespace RegularExpressions_RegEx__Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MatchFullName
    {
        public static void Main()
        {
            string names = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+\s+[A-Z][a-z]+\b";
            var isMatch = Regex.Matches(names, pattern);

            foreach (Match name in isMatch)
            {
                Console.Write($"{name} ");
            }
        }
    }
}
