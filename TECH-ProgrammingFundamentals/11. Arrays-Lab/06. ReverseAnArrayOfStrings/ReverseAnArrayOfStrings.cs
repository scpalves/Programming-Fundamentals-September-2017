using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseAnArrayOfStrings
{
    static void Main()
    {
        var stringArray = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
        Console.WriteLine(string.Join(" ",stringArray));
    }
}

