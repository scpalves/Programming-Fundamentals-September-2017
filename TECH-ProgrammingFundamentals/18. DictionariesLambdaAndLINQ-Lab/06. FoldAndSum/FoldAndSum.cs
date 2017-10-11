namespace _06.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;
            var leftSide = numbers.Take(k).Reverse().ToArray();
            var middleSide = numbers.Skip(k).Take(2 * k).ToArray();
            var rightSide = numbers.Skip(3 * k).Take(k).Reverse().ToArray();
            var topSide = leftSide.Concat(rightSide).ToArray();

            for (int i = 0; i < k * 2; i++)
            {
                middleSide[i] += topSide[i];
            }

            Console.WriteLine(string.Join(" ",middleSide));
        }
    }
}
