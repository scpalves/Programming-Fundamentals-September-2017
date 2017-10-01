using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringConcatenation
{
    static void Main()
    {
        char separator = char.Parse(Console.ReadLine());
        string oddOrEvenWord = Console.ReadLine();
        int numberOfWords = int.Parse(Console.ReadLine());
        string evenWords = string.Empty;
        string oddWords = string.Empty;

        for (int i = 1; i <= numberOfWords; i++)
        {
            string currentWord = Console.ReadLine();

            if (oddOrEvenWord == "even")
            {
                if (i % 2 == 0)
                {
                    evenWords += currentWord + separator;
                }
            }
            else
            {
                if (i % 2 != 0)
                {
                    oddWords += currentWord + separator;
                }
            }
        }
        evenWords = evenWords.TrimEnd(separator);
        oddWords = oddWords.TrimEnd(separator);

        if (oddOrEvenWord == "even")
        {
            Console.WriteLine(evenWords);
        }
        else
        {
            Console.WriteLine(oddWords);
        }
    }
}

