using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CakeIngredients
{
    static void Main()
    {
        var ingredient = Console.ReadLine();
        var ingredientCounter = 0;

        while (ingredient != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {ingredient}.");
            ingredientCounter++;
            ingredient = Console.ReadLine();
        }

        Console.WriteLine($"Preparing cake with {ingredientCounter} ingredients.");
    }
}

