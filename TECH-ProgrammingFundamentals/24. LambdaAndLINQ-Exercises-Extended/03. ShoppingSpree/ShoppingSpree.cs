namespace _03.ShoppingSpree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingSpree
    {
        private static Dictionary<string, decimal> foodData =
            new Dictionary<string, decimal>();
        public static void Main()
        {
            decimal peshoBudget = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                var inputTokens = input
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string food = inputTokens[0];
                decimal price = decimal.Parse(inputTokens[1]);
                AddToFoodData(food, price);
                input = Console.ReadLine();
            }

            decimal moneyForFood = foodData.Values.Sum();
            if (moneyForFood > peshoBudget)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                foreach (var items in foodData.OrderByDescending(x => x.Value).ThenBy(x => x.Key.Length))
                {
                    string food = items.Key;
                    decimal price = items.Value;
                    Console.WriteLine($"{food} costs {price:f2}");
                }
            }
        }

        public static void AddToFoodData(string food, decimal price)
        {
            if (!foodData.ContainsKey(food))
            {
                foodData.Add(food, price);
            }
            else
            {
                if (price < foodData[food])
                {
                    foodData[food] = price;
                }
            }
        }

       
    }
}
