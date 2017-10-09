namespace Lists_Lab
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            bool arePositiveNumbers = false;
            var positiveNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                    arePositiveNumbers = true;
                }
            }

            if (arePositiveNumbers)
            {
                Console.WriteLine(string.Join(" ", positiveNumbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
