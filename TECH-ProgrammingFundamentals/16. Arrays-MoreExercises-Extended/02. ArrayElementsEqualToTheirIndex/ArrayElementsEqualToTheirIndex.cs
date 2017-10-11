namespace _02.ArrayElementsEqualToTheirIndex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayElementsEqualToTheirIndex
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (currentNumber == i)
                {
                    Console.Write(currentNumber + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
