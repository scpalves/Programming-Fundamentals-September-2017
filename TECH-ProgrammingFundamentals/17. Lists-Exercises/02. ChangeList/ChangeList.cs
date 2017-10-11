namespace _02.ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChangeList
    {
        static List<int> numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        public static void Main()
        {
            var tokens = Console.ReadLine();

            while (true)
            {
                var command = tokens
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Delete")
                {
                    int element = int.Parse(command[1]);
                    DeleteItemInList(element);
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    InsertItemInList(index, element);
                }
                else if (command[0] == "Odd")
                {
                    PrintOddElementsFromList();
                    break;
                }
                else if (command[0] == "Even")
                {
                    PrintEvenElementsFromList();
                    break;
                }
                tokens = Console.ReadLine();
            }
        }

        public static void DeleteItemInList(int element)
        {
            numbers.RemoveAll(x => x == element);
        }

        public static void InsertItemInList(int index, int numberToInsert)
        {
            numbers.Insert(index, numberToInsert);
        }

        public static void PrintOddElementsFromList()
        {
            numbers = numbers.Where(x => x % 2 != 0).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }

        public static void PrintEvenElementsFromList()
        {
            numbers = numbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
