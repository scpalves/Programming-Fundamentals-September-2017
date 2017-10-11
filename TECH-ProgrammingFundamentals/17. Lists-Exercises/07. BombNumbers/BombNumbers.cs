namespace _07.BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                var leftSum = numbers.Take(i).ToArray();
                var rightSum = numbers.Skip(i + 1).ToArray();
                if (leftSum.Sum() == rightSum.Sum())
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
