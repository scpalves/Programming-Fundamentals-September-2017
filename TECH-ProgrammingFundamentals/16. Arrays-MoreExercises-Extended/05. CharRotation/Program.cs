namespace _05.CharRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string words = Console.ReadLine();
            var numbers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var symbols = new char[numbers.Length];

            for (int i = 0; i < words.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    symbols[i] = (char) (words[i] - numbers[i]);
                }
                else
                {
                    symbols[i] = (char) (words[i] + numbers[i]);
                }
            }

            Console.WriteLine(string.Join("",symbols));
        }
    }
}
