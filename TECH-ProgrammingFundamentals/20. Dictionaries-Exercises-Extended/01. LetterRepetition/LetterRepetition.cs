namespace Dictionaries_Exercises_Extended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LetterRepetition
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var letterRepetition = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!letterRepetition.ContainsKey(letter))
                {
                    letterRepetition.Add(letter, 0);
                }
                letterRepetition[letter]++;
            }

            foreach (var letters in letterRepetition)
            {
                char letter = letters.Key;
                int counter = letters.Value;

                Console.WriteLine($"{letter} -> {counter}");
            }
        }
    }
}
