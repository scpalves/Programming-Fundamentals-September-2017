using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BeerKegs
{
    static void Main()
    {
        int numberOfKegs = int.Parse(Console.ReadLine());
        double biggestKeg = 0;
        string kegName = string.Empty;

        for (int i = 0; i < numberOfKegs; i++)
        {
            string modelOfKeg = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volumeOfCurrentKeg = Math.PI * Math.Pow(radius, 2) * height;

            if (volumeOfCurrentKeg > biggestKeg)
            {
                biggestKeg = volumeOfCurrentKeg;
                kegName = modelOfKeg;
            }
        }

        Console.WriteLine(kegName);
    }
}

