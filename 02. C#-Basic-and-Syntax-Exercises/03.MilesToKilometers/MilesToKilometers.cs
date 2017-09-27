using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MilesToKilometers
{
    static void Main()
    {
        var singleMile = 1.60934;
        var km = double.Parse(Console.ReadLine());
        var kmToMiles = km * singleMile;
        Console.WriteLine($"{kmToMiles:f2}");
    }
}

