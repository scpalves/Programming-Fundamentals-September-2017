namespace _07.ResizableArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ResizableArray
    {
        public static List<int> numbers;
        public static void Main()
        {
            numbers = new List<int>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = inputTokens[0];
                switch (command)
                {
                    case "push":
                        int element = int.Parse(inputTokens[1]);
                        Push(element);
                        break;
                    case "pop":
                        Pop();
                        break;
                    case "removeAt":
                        int index = int.Parse(inputTokens[1]);
                        RemoveAtIndex(index);
                        break;
                    case "clear":
                        numbers.Clear();
                        break;
                }
                input = Console.ReadLine();
            }

            if (numbers.Count != 0)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
            else
            {
                Console.WriteLine("empty array");
            }
        }

        public static void Push(int element)
        {
            numbers.Add(element);
        }

        public static void Pop()
        {
            numbers.Remove(numbers[numbers.Count - 1]);
        }

        public static void RemoveAtIndex(int index)
        {
            numbers.RemoveAt(index);
        }

        public static void ClearList()
        {
            numbers.Clear();
        }
    }
}
