using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class VariableInHexFormat
{
    static void Main()
    {
        string hexadecimalFormat = Console.ReadLine();

        int convertedToNumber = Convert.ToInt32(hexadecimalFormat, 16);

        Console.WriteLine(convertedToNumber);
    }
}

