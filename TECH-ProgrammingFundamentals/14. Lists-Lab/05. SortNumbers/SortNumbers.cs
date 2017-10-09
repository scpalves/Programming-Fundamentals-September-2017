namespace _05.SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections;
    class SortNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            numbers.Sort();
            Console.WriteLine(string.Join(" <= ", numbers));

        }
    }
}
