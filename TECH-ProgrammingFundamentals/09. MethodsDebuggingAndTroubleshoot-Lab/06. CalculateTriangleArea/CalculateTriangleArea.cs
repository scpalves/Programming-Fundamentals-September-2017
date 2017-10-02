using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateTriangleArea
{
    static void Main()
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        var triangleArea = TriangleArea(width, height);

        Console.WriteLine(triangleArea);
    }

    static double TriangleArea(double width, double height)
    {
        var triangleArea = width * height / 2;
        return triangleArea;
    }
}

