using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringsAndObjects
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        object finalSentence = firstInput + " " + secondInput;
        string objectToString = (string)finalSentence;

        Console.WriteLine(objectToString);
    }
}

