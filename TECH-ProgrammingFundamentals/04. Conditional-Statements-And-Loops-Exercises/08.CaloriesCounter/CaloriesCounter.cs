using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var countOfProducts = int.Parse(Console.ReadLine());

        var cheese = 500;
        var tomatoSauce = 150;
        var salami = 600;
        var pepper = 50;
        var totalCalories = 0;

        for (int i = 0; i < countOfProducts; i++)
        {
            var product = Console.ReadLine().ToLower();
            if (product == "cheese")
            {
                totalCalories += cheese;
            }
            else if (product == "tomato sauce")
            {
                totalCalories += tomatoSauce;
            }
            else if (product == "salami")
            {
                totalCalories += salami;
            }
            else if (product == "pepper")
            {
                totalCalories += pepper;
            }
        }

        Console.WriteLine($"Total calories: {totalCalories}");
    }
}

