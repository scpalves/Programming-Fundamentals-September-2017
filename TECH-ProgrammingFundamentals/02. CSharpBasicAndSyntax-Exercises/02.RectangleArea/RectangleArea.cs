using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RectangleArea
{
    static void Main(string[] args)
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        var rectangleArea = width * height;
        Console.WriteLine($"{rectangleArea:f2}");
    }
}

