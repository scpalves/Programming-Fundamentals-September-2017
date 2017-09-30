using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExchangeVariableValues
{
    static void Main()
    {
        byte a = byte.Parse(Console.ReadLine());
        byte b = byte.Parse(Console.ReadLine());

        Console.WriteLine("Before:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");

        byte saveFirstValue = a;
        a = b;
        b = saveFirstValue;

        Console.WriteLine("After:");
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }
}
