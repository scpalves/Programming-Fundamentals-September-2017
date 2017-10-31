namespace _02.PokemonDontGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PokemonDontGo
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            long totalSum = 0;

            while (numbers.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int lastRemovedElement;

                if (index < 0)
                {
                    lastRemovedElement = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                    IncreasingLowerElementsAndDecreasingHigherEleemnts(numbers, lastRemovedElement);
                }
                else if (index > numbers.Count - 1)
                {
                    lastRemovedElement = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                    IncreasingLowerElementsAndDecreasingHigherEleemnts(numbers, lastRemovedElement);
                }
                else
                {
                    lastRemovedElement = numbers[index];
                    numbers.RemoveAt(index);
                    IncreasingLowerElementsAndDecreasingHigherEleemnts(numbers, lastRemovedElement);
                }

                totalSum += lastRemovedElement;
            }

            Console.WriteLine(totalSum);
        }

        private static void IncreasingLowerElementsAndDecreasingHigherEleemnts(List<int> numbers, int lastRemovedElement)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = (numbers[i] <= lastRemovedElement)
                    ? numbers[i] += lastRemovedElement
                    : numbers[i] -= lastRemovedElement;
            }
        }
    }
}
