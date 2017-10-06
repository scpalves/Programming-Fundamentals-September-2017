using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GeometryCalculator
{
    static void Main()
    {
        var geometricFigure = Console.ReadLine();
        var area = 0.0;
        if (geometricFigure == "triangle")
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            area = TriangleArea(side, height);
        }
        else if (geometricFigure == "square")
        {
            var side = double.Parse(Console.ReadLine());
            area = SquareArea(side);
        }
        else if (geometricFigure == "rectangle")
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            area = RectangleArea(width, height);
        }
        else if (geometricFigure == "circle")
        {
            var radius = double.Parse(Console.ReadLine());
            area = RadiusOfCircle(radius);
        }
        Console.WriteLine($"{area:f2}");
    }

    static double TriangleArea(double side, double height)
    {
        var triangleArea = side * height / 2;
        return triangleArea;
    }

    static double SquareArea(double side)
    {
        var squareArea = side * side;
        return squareArea;
    }

    static double RectangleArea(double width, double height)
    {
        var rectangleArea = width * height;
        return rectangleArea;
    }

    static double RadiusOfCircle(double radius)
    {
        var radiusOfCircle = Math.PI * radius * radius;
        return radiusOfCircle;
    }
}

