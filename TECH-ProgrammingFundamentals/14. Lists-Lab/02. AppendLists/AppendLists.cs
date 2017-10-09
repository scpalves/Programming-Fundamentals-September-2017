namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AppendLists
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

           var appendedLists = new List<string>();
            appendedLists.AddRange(numbers);

            Console.WriteLine(string.Join(" ",appendedLists));
        }
    }
}
