using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PizzaIngredients
{
    static void Main()
    {
        var ingredients = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var ingredientsNameLenght = int.Parse(Console.ReadLine());
        
        var saveUsedIngredients = new List<string>();
        int ingredientCounter = 0;

        foreach (var ingredient in ingredients)
        {
            if (ingredient.Length == ingredientsNameLenght)
            {
                ingredientCounter++;
                saveUsedIngredients.Add(ingredient);
                Console.WriteLine($"Adding {ingredient}.");
            }
            if (ingredientCounter == 10)
            {
                break;
            }
        }
        
        Console.WriteLine($"Made pizza with total of {ingredientCounter} ingredients.");
        Console.WriteLine($"The ingredients are: {string.Join(", ",saveUsedIngredients)}.");
    }
}

