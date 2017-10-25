namespace _03.TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TextFilter
    {
        public static void Main()
        {
            
            string[] bannedWords = Console.ReadLine()
                .Split(new [] {", "}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
