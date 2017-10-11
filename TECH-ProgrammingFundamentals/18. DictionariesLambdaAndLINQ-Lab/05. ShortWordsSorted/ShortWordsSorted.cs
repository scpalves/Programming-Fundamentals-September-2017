namespace _05.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var seperators = ",.:;()[]\"'\\/!? ".ToCharArray();

            var words = Console.ReadLine()
                .ToLower()
                .Split(seperators, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .OrderBy(w => w)
                .ToList();

            Console.WriteLine(string.Join(", ",words));
        }
    }
}
