namespace _03.Spyfer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Spyfer
    {
        public static void Main()
        {
            var cordinates = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < cordinates.Count; i++)
            {
                if (i != 0 && i != cordinates.Count - 1
                    && cordinates[i - 1] + cordinates[i + 1] == cordinates[i])
                {
                    cordinates.RemoveAt(i + 1);
                    cordinates.RemoveAt(i - 1);
                    i = -1;
                }
                else if (i == 0 && cordinates.Count >= 2 && cordinates[i] == cordinates[i + 1])
                {
                    cordinates.RemoveAt(i);
                    i = -1;
                }
                else if (i == cordinates.Count - 1 && cordinates.Count >= 2 && cordinates[i] == cordinates[i - 1])
                {
                    cordinates.RemoveAt(i);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", cordinates));
        }
    }
}
