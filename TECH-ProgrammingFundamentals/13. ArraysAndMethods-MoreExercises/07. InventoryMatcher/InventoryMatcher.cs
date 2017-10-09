using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InventoryMatcher
{
    static string[] products;
    static long[] quantity;
    static decimal[] price;
    static void Main()
    {
        
        ReadingProductData();

        var searchingForProduct = Console.ReadLine();

        while (searchingForProduct != "done")
        {
            int productIndex = Array.IndexOf(products, searchingForProduct);
            Console.WriteLine($"{searchingForProduct} costs: {price[productIndex]}; Available quantity: {quantity[productIndex]}");
            searchingForProduct = Console.ReadLine();
        }
    }

    private static void ReadingProductData()
    {
        products = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        quantity = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        price = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();
    }
}

