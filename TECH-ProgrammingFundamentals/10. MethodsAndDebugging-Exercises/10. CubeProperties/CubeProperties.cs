using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var lenght = double.Parse(Console.ReadLine());
        var parameter = Console.ReadLine();

        var result = 0.0;
        if (parameter == "face")
        {
           result = FaceDiagonal(lenght);
        }
        else if (parameter == "space")
        {
            result = SpaceDiagonal(lenght);
        }
        else if (parameter == "volume")
        {
            result = Volume(lenght);
        }
        else if (parameter == "area")
        {
            result = SurfaceArea(lenght);
        }
        Console.WriteLine($"{result:f2}");
    }

    static double FaceDiagonal(double lenght)
    {
        var faceDiagonal = Math.Sqrt(2 * Math.Pow(lenght, 2));
        return faceDiagonal;
    }

    static double SpaceDiagonal(double lenght)
    {
        var spaceDiagonal = Math.Sqrt(3 * Math.Pow(lenght, 2));
        return spaceDiagonal;
    }

    static double Volume(double lenght)
    {
        var volume = Math.Pow(lenght, 3);
        return volume;
    }

    static double SurfaceArea (double lenght)
    {
        var surfaceArea = 6 * Math.Pow(lenght, 2);
        return surfaceArea;
    }
}

