namespace _05.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        static List<long> numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(long.Parse)
               .ToList();

        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "print")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];

                if (command == "add")
                {
                    int index = int.Parse(tokens[1]);
                    int element = int.Parse(tokens[2]);
                    InsertElement(index, element);
                }
                else if (command == "addMany")
                {
                    int index = int.Parse(tokens[1]);
                    var elements = tokens.Skip(2).Select(long.Parse).ToList();
                    AddRangeOfElements(index, elements);
                }
                else if (command == "contains")
                {
                    long element = long.Parse(tokens[1]);
                    ContainsCurrentElement(element);
                }
                else if (command == "remove")
                {
                    int index = int.Parse(tokens[1]);
                    RemoveElementFromList(index);
                }
                else if (command == "shift")
                {
                    int rotations = int.Parse(tokens[1]);
                    ShiftListToTheLeft(rotations);
                }
                else if (command == "sumPairs")
                {
                    SumPairs();
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        public static void InsertElement(int index, int element)
        {
            numbers.Insert(index, element);
        }

        public static void AddRangeOfElements(int index, List<long> numbersToAdd)
        {
            numbers.InsertRange(index, numbersToAdd);
        }

        public static void ContainsCurrentElement(long element)
        {
            Console.WriteLine(numbers.IndexOf(element));
        }

        public static void RemoveElementFromList(int index)
        {
            numbers.RemoveAt(index);
        }

        public static void ShiftListToTheLeft(int rotations)
        {
            for (int a = 0; a < rotations % numbers.Count; a++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
        }

        public static void SumPairs()
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                numbers[i + 1] = numbers[i] + numbers[i + 1];
                numbers.RemoveAt(i);
            }
        }
    }
}
