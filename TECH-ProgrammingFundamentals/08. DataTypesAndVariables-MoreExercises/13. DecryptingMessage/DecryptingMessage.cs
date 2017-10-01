using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecryptingMessage
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int numberOfLetters = int.Parse(Console.ReadLine());
        string cryptedMessage = string.Empty;

        for (int i = 0; i < numberOfLetters; i++)
        {
            char currentLetter = char.Parse(Console.ReadLine());
            int newLetter = currentLetter + key;
            cryptedMessage += (char)newLetter;
        }

        Console.WriteLine(cryptedMessage);
    }
}

