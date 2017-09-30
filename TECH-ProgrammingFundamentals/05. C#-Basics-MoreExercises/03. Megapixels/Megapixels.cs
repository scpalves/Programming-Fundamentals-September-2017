using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Megapixels
{
    static void Main()
    {
        var width = int.Parse(Console.ReadLine());
        var height = int.Parse(Console.ReadLine());

        var countingPixels = width * height;
        var pixels = Math.Round(countingPixels / 1000000.0, 1);

        Console.WriteLine($"{width}x{height} => {pixels}MP");
    }
}

