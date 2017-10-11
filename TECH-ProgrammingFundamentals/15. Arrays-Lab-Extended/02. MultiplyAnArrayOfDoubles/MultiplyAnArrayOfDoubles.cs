namespace _02.MultiplyAnArrayOfDoubles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MultiplyAnArrayOfDoubles
    {

        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double multiplyer = double.Parse(Console.ReadLine());

            numbers = numbers.Select(x => x * multiplyer).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
