using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PracticeCharsAndStrings
{
    static void Main()
    {
        string firstSentence = Console.ReadLine();
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        char thirdLetter = char.Parse(Console.ReadLine());
        string secondSentence = Console.ReadLine();

        Console.WriteLine(firstSentence);
        Console.WriteLine(firstLetter);
        Console.WriteLine(secondLetter);
        Console.WriteLine(thirdLetter);
        Console.WriteLine(secondSentence);
    }
}

