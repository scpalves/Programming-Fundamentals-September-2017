using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TouristInformation
{
    static void Main()
    {
        string imperialUnit = Console.ReadLine();
        double value = double.Parse(Console.ReadLine());
        string transferedTo = string.Empty;
        Console.Write($"{value} {imperialUnit} = ");

        if (imperialUnit == "miles")
        {
            value *= 1.6;
            transferedTo += "kilometers";
        }
        else if (imperialUnit == "inches")
        {
            value *= 2.54;
            transferedTo += "centimeters";
        }
        else if (imperialUnit == "feet")
        {
            value *= 30;
            transferedTo += "centimeters";
        }
        else if (imperialUnit == "yards")
        {
            value *= 0.91;
            transferedTo += "meters";
        }
        else
        {
            value *= 3.8;
            transferedTo += "liters";
        }

        Console.WriteLine($"{value:f2} {transferedTo}");
    }
}

