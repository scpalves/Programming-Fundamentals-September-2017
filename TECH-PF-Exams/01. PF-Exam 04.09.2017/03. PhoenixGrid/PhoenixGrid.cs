namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class PhoenixGrid
    {
        public static void Main()
        {
            while (true)
            {
                string inputLine = Console.ReadLine();
                string pattern = @"[^\s_]{3}(\.[^\s_]{3})*";

                if (inputLine == "ReadMe")
                {
                    break;
                }
                
                var match = Regex.Match(inputLine, pattern);

                if (match.Success)
                {
                    string text = match.Value;

                    if (IsPalindrome(text))
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        public static bool IsPalindrome(string word)
        {
            StringBuilder reversedWord = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord.Append(word[i]);
            }

            if (reversedWord.ToString() == word)
            {
                return true;
            }

            return false;
        }
    }
}
