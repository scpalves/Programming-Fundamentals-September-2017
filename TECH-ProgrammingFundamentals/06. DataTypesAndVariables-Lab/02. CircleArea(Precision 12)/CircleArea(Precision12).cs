using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var radius = double.Parse(Console.ReadLine());
        var radiusOfCircle = Math.PI * radius * radius;

        Console.WriteLine($"{radiusOfCircle:f12}");
    }
}

