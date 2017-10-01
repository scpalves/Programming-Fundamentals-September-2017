using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WordInPlural
{
    static void Main()
    {
        var inputWord = Console.ReadLine();

        if (inputWord.EndsWith("y"))
        {
            inputWord = inputWord.Replace("y", "ies");
        }
        else if (inputWord.EndsWith("o") || inputWord.EndsWith("ch") || inputWord.EndsWith("s") || inputWord.EndsWith("sh") || inputWord.EndsWith("x") || inputWord.EndsWith("z"))
        {
            inputWord += "es";
        }
        else
        {
            inputWord += "s";
        }

        Console.WriteLine(inputWord);
    }
}

