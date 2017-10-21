namespace _02.RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int firstWord = rnd.Next(0, words.Length);
                int secondWord = rnd.Next(0, words.Length);

                string changer = words[firstWord];
                words[firstWord] = words[secondWord];
                words[secondWord] = changer;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
