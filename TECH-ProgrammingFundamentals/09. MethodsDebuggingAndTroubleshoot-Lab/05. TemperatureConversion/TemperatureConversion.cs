using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TemperatureConversion
{
    static void Main()
    {
        var farenheit = double.Parse(Console.ReadLine());
        var celsius = FromFarenheitToCelsius(farenheit);

        Console.WriteLine($"{celsius:f2}");
        
    }
    
    static double FromFarenheitToCelsius(double farenheit)
    {
        var celsius = (farenheit - 32) * 5 / 9;
        return celsius;
    }
}

