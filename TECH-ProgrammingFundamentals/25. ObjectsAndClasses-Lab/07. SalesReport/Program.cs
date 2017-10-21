using System.Security.Cryptography.X509Certificates;

namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var sales = new Dictionary<string, Sale>();
            for (int i = 0; i < n; i++)
            {
                var items = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string town = items[0];
                if (!sales.ContainsKey(town))
                {
                    string product = items[1];
                    decimal price = decimal.Parse(items[2]);
                    decimal quantity = decimal.Parse(items[3]);
                    sales.Add(town, new Sale(town, product, price, quantity));
                }
            }

            foreach (var sale in sales.Select(x => x.Value.Price * x.Value.Quantity))
            {
                
                
                Console.WriteLine(sale);
                
            }
        }
    }

    public class Sale
    {
        public Sale(string town, string product, decimal price, decimal quantity)
        {
            this.Town = town;
            this.Product = product;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }
    }

}
