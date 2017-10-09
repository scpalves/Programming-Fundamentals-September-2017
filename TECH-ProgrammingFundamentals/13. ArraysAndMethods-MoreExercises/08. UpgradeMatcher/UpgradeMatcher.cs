using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UpgradeMatcher
{
    static void Main()
    {
        string[] products;
        long[] quantityOfProducts;
        decimal[] priceOfProducts;
        ReadingProductsData(out products, out quantityOfProducts, out priceOfProducts);

        var items = Console.ReadLine();

        while (items != "done")
        {
            var productAndQuantity = items
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string product = productAndQuantity[0];
            long quantity = long.Parse(productAndQuantity[1]);
            int indexOfProduct = Array.IndexOf(products, product);

            //Checking if we dont have any quantity OR we are running out of it OR less of ordered qunatity.
            if (indexOfProduct > quantityOfProducts.Length - 1 || quantityOfProducts[indexOfProduct] <= 0 ||
                quantity > quantityOfProducts[indexOfProduct])
            {
                Console.WriteLine($"We do not have enough {product}");
            }
            else
            {
                Console.WriteLine($"{product} x {quantity} costs {quantity * priceOfProducts[indexOfProduct]:f2}");
                quantityOfProducts[indexOfProduct] -= quantity;
            }

            items = Console.ReadLine();
        }

    }

    static void ReadingProductsData(out string[] products, out long[] quantityOfProduct, out decimal[] priceOfProduct)
    {
        products = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        quantityOfProduct = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        priceOfProduct = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();
    }
}

