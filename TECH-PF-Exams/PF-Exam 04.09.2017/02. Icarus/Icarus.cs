namespace _02.Icarus
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Icarus
    {
        public static void Main()
        {
            long[] array = ReadingArrayOfInputLine();
            int startIndex = int.Parse(Console.ReadLine());
            int damage = 1;

            while (true)
            {
                var inputLine = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputLine[0] == "Supernova")
                {
                    break;
                }

                string direction = inputLine[0];
                int jumps = int.Parse(inputLine[1]);

                MovingLeftThroughArray(array, ref startIndex, ref damage, direction, jumps);
                MovingRightThroughArray(array, ref startIndex, ref damage, direction, jumps);
            }

            Console.WriteLine(string.Join(" ", array));
        }

        private static void MovingRightThroughArray(long[] array, ref int startIndex, ref int damage, string direction, int jumps)
        {
            if (direction == "right")
            {
                for (int i = 0; i < jumps; i++)
                {
                    if (startIndex + 1 > array.Length - 1)
                    {
                        startIndex = -1;
                        damage++;
                    }
                    array[startIndex + 1] -= damage;
                    startIndex++;
                }
            }
        }

        private static void MovingLeftThroughArray(long[] array, ref int startIndex, ref int damage, string direction, int jumps)
        {
            if (direction == "left")
            {
                for (int i = 0; i < jumps; i++)
                {
                    if (startIndex - 1 < 0)
                    {
                        startIndex = array.Length;
                        damage++;
                    }
                    array[startIndex - 1] -= damage;
                    startIndex--;
                }
            }
        }


        private static long[] ReadingArrayOfInputLine()
        {
            var numbers = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(long.Parse)
                 .ToArray();

            return numbers;
        }
    }
}
