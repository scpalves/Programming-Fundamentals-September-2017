namespace _02.CountSubstringOccurunces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSubstringOccurunces
    {
        public static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();
            int index = text.IndexOf(substring);
            int counter = 0;

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(substring, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
