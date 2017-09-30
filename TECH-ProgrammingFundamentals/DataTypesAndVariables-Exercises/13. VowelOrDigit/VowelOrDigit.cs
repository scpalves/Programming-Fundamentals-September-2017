using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VowelOrDigit
{
    static void Main()
    {
        var inputSymbol = Console.ReadLine();

        if (inputSymbol == "a" || inputSymbol == "e" || inputSymbol == "i" || inputSymbol == "o" || inputSymbol == "u")
        {
            Console.WriteLine("vowel");
        }
        else if (inputSymbol == "0" || inputSymbol == "1" || inputSymbol == "2" || inputSymbol == "3" || inputSymbol == "4" || 
                 inputSymbol == "5"|| inputSymbol == "6" || inputSymbol == "7" || inputSymbol == "8" || inputSymbol == "9" )
        {
            Console.WriteLine("digit");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}

