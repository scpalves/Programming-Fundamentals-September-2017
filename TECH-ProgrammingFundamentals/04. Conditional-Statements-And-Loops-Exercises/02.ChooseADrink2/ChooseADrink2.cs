using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ChooseADrink2
{
    static void Main()
    {
        var input = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());
        var water = 0.70;
        var coffee = 1;
        var beer = 1.7;
        var tea = 1.2;
        var price = 0.0;
        switch (input)
        {
            case "Athlete":
                price = water * quantity;
                Console.WriteLine($"The Athlete has to pay {price:f2}.");
                break;
            case "Businessman":
            case "Businesswoman":
                price = coffee * quantity;
                Console.WriteLine($"The {input} has to pay {price:f2}.");
                break;
            case "SoftUni Student":
                price = beer * quantity;
                Console.WriteLine($"The {input} has to pay {price:f2}.");
                break;
            default:
                price = tea * quantity;
                Console.WriteLine($"The {input} has to pay {price:f2}.");
                break;
        }
    }
}

