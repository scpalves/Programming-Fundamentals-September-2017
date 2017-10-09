namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var squareNumbers = new List<int>();
            foreach (var number in numbers)
            {
                if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                {
                    squareNumbers.Add(number);
                }
            }

            squareNumbers = squareNumbers.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" ",squareNumbers));
        }
    }
}
