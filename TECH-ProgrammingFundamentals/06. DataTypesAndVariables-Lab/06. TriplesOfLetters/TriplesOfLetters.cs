using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TriplesOfLetters
{
    static void Main(string[] args)
    {
        int lettersCount = int.Parse(Console.ReadLine());

        for (char a = 'a'; a < 'a' + lettersCount; a++)
        {
            for (char b = 'a'; b < 'a' + lettersCount; b++)
            {
                for (char c = 'a'; c < 'a' + lettersCount; c++)
                {
                    Console.WriteLine($"{a}{b}{c}");
                }
            }
        }
    }
}

