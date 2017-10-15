namespace DictionariesAndLists_MoreExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortTimes
    {
        public static void Main()
        {
            var time = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => Convert.ToDateTime(x).ToString("HH:mm"))
                .ToList();

            time.Sort();
            Console.WriteLine(string.Join(", ", time));

        }
    }
}
