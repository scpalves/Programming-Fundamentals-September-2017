using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IndeOfLetters
{
    static void Main(string[] args)
    {
        var letters = Console.ReadLine();

        foreach (var letter in letters)
        {
            Console.WriteLine($"{letter} -> {letter - 97}");
        }
    }
}

