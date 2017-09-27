using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicLetter
{
    static void Main()
    {
        var firstLetter = char.Parse(Console.ReadLine());
        var secondLetter = char.Parse(Console.ReadLine());
        var skipLetter = char.Parse(Console.ReadLine());

        for (char a = firstLetter; a <= secondLetter; a++)
        {
            for (char b = firstLetter; b <= secondLetter; b++)
            {
                for (char c = firstLetter; c <= secondLetter; c++)
                {
                    if (a != skipLetter && b != skipLetter && c != skipLetter)
                    {
                        Console.Write($"{a}{b}{c} ");
                    }
                }
            }
        }
    }
}

