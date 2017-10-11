namespace _05.CountOfOddNumbersInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountOfOddNumbersInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int oddCounter = 0;

            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    oddCounter++;
                }
            }

            Console.WriteLine(oddCounter);
        }
    }
}
