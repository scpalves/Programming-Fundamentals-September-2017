namespace _04.ExamShopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ExamShopping
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var products = new Dictionary<string, int>();

            while (input != "shopping time")
            {
                var inputTokens = input
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string command = inputTokens[0];

                if (command == "stock")
                {
                    string productName = inputTokens[1];
                    int quantity = int.Parse(inputTokens[2]);
                    if (!products.ContainsKey(productName))
                    {
                        products.Add(productName, 0);
                    }
                    products[productName] += quantity;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "exam time")
            {
                var inputTokens = input
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string command = inputTokens[0];

                if (command == "buy")
                {
                    string productName = inputTokens[1];
                    int quantity = int.Parse(inputTokens[2]);

                    if (products.ContainsKey(productName))
                    {
                        if (products[productName] == 0)
                        {
                            Console.WriteLine($"{productName} out of stock");
                        }
                        else if (products[productName] < quantity)
                        {
                            products[productName] = 0;
                        }
                        else
                        {
                            products[productName] -= quantity;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{productName} doesn't exist");
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in products.Where(x => x.Value > 0))
            {
                string product = item.Key;
                int quantity = item.Value;
                Console.WriteLine($"{product} -> {quantity}");
            }
        }
    }
}
