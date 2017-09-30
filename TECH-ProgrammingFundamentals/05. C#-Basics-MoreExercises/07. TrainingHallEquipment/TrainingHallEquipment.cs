using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TrainingHallEquipment
{
    static void Main()
    {
        var budget = decimal.Parse(Console.ReadLine());
        var items = int.Parse(Console.ReadLine());

        var totalPrice = 0m;

        for (int i = 0; i < items; i++)
        {
            var itemName = Console.ReadLine();
            var itemPrice = decimal.Parse(Console.ReadLine());
            var itemCount = int.Parse(Console.ReadLine());
            totalPrice += itemPrice * itemCount;

            if (itemCount > 1)
            {
                Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
            }
            else
            {
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
            }
        }

        Console.WriteLine($"Subtotal: ${totalPrice:f2}");

        if (budget >= totalPrice)
        {
            var moneyLeft = budget - totalPrice;
            Console.WriteLine($"Money left: ${moneyLeft:f2}");
        }
        else
        {
            var neededMoney = Math.Abs(budget - totalPrice);
            Console.WriteLine($"Not enough. We need ${neededMoney:f2} more.");
        }
    }
}

