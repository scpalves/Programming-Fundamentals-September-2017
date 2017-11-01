using System.Text.RegularExpressions;

namespace _03.Trainegram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Trainegram
    {
        public static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Traincode!")
                {
                    break;
                }

                string pattern = @"^([\<]\[[^a-z0-9A-Z]*\][\.]{1})(\.{1}\[[a-zA-Z0-9]*\]\.{1})*$";
                var match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
