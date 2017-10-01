using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BeverageLabels
{
    static void Main()
    {
        var productName = Console.ReadLine();
        var volume = int.Parse(Console.ReadLine());
        var energy = int.Parse(Console.ReadLine());
        var sugar = int.Parse(Console.ReadLine());

        var totalEnergy = energy / 100.0 * volume;
        var totalSugar = sugar * volume / 100.0;

        Console.WriteLine($"{volume}ml {productName}:");
        Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
    }
}

