using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IntegerToHexAndBinary
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        string numberInHexadecimal = Convert.ToString(number, 16).ToUpper();
        string binary = Convert.ToString(number, 2);
        
        Console.WriteLine(numberInHexadecimal);
        Console.WriteLine(binary);
    }
}

