using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CenterPoint
{
    static void Main()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        GetClosedPointToZero(x1, y1, x2, y2);
    }

    static void GetClosedPointToZero(double x1, double y1, double x2, double y2)
    {
        double c1 = Math.Abs(Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)));
        double c2 = Math.Abs(Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2)));
        if (c2 < c1)
        {
            Console.WriteLine($"({x2}, {y2})");
        }
        else
        {
            Console.WriteLine($"({x1}, {y1})");
        }
    }
}


