using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MakeAWord
{
    static void Main()
    {
        int numberOfChars = int.Parse(Console.ReadLine());
        string saveChars = string.Empty;

        for (int i = 0; i < numberOfChars; i++)
        {
            char currentChar = char.Parse(Console.ReadLine());
            saveChars += currentChar;
        }

        Console.WriteLine($"The word is: {saveChars}");
    }
}

