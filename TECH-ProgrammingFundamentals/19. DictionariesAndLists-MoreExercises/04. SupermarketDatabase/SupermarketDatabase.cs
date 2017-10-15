namespace _04.SupermarketDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SupermarketDatabase
    {
        static Dictionary<string, Dictionary<decimal, int>> supermarketData =
            new Dictionary<string, Dictionary<decimal, int>>();
        public static void Main()
        {
            string input = Console.ReadLine();


            while (input != "stocked")
            {
                var inputTokens = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string product = inputTokens[0];
                decimal price = decimal.Parse(inputTokens[1]);
                int quantity = int.Parse(inputTokens[2]);

                AddToSupermarket(product, price, quantity);

                input = Console.ReadLine();
            }
            PrintSupermarketData();
        }

        public static void AddToSupermarket(string product, decimal price, int quantity)
        {
            if (!supermarketData.ContainsKey(product))
            {
                supermarketData.Add(product, new Dictionary<decimal, int>());
            }
            supermarketData[product].Add(price, quantity);
        }

        public static void PrintSupermarketData()
        {
            decimal grandTotal = 0m;
            foreach (var supermarket in supermarketData)
            {
                string product = supermarket.Key;
                decimal price = supermarket.Value.Keys.Last();
                decimal quantity = supermarket.Value.Values.Sum();
                decimal currentCheck = price * quantity;
                grandTotal += currentCheck;

                Console.Write($"{product}: ");
                Console.WriteLine($"${price:f2} * {quantity} = ${currentCheck:f2}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
