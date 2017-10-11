namespace _06.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                var numberToStr = numbers[i].ToString().Reverse().ToArray();
                numbers[i] = int.Parse(new string(numberToStr));
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}
