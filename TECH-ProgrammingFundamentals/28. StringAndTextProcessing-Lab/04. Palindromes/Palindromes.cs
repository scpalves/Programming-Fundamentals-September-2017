using System.Text;

namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            var separators = " ,.?!".ToCharArray();
            var text = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var saveUniquePalindromeWords = new SortedSet<string>();

            foreach (var word in text)
            {
                if (IsPalindrome(word))
                {
                    saveUniquePalindromeWords.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ",saveUniquePalindromeWords));
        }

        public static bool IsPalindrome(string word)
        {
            var palindromeWords = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                palindromeWords += word[i];
            }

            if (palindromeWords == word)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
