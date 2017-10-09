namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SplitByWordCasing
    {
        public static void Main()
        {
            char[] seperators = ",;.:!()\"'\\/[] ".ToCharArray();
            var words = Console.ReadLine()
                .Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            var saveLowerCaseWords = new List<string>();
            var saveUpperCaseWords = new List<string>();
            var saveMixedCaseWords = new List<string>();

            foreach (var word in words)
            {
                if (FindingLowerCaseWords(word))
                {
                    saveLowerCaseWords.Add(word);
                }
                else if (FindingUpperCaseWords(word))
                {
                    saveUpperCaseWords.Add(word);
                }
                else
                {
                    saveMixedCaseWords.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", saveLowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", saveMixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", saveUpperCaseWords)}");

        }

        public static bool FindingLowerCaseWords(string input)
        {
            if (input.All(char.IsLower))
            {
                return true;
            }
            return false;
        }

        public static bool FindingUpperCaseWords(string input)
        {
            if (input.All(char.IsUpper))
            {
                return true;
            }
            return false;
        }
    }
}
