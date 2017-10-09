using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Heists
{
    static void Main()
    {
        var input = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        decimal priceOfJewels = decimal.Parse(input[0]);
        decimal priceOfGold = decimal.Parse(input[1]);
        string tokens = Console.ReadLine();
        decimal totalExpenses = 0m;
        decimal totalEarnings = 0m;

        while (tokens != "Jail Time")
        {
            var items =
                tokens.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string loot = items[0];
            decimal expenses = decimal.Parse(items[1]);
            totalEarnings += SearchingForJewelsOrGold(loot, priceOfJewels, priceOfGold);
            totalExpenses += expenses;
            tokens = Console.ReadLine();
        }

        PrintEarningsAndLosses(totalExpenses, totalEarnings);
    }

    private static void PrintEarningsAndLosses(decimal totalExpenses, decimal totalEarnings)
    {
        if (totalEarnings >= totalExpenses)
        {
            decimal profit = totalEarnings - totalExpenses;
            Console.WriteLine($"Heists will continue. Total earnings: {profit}.");
        }
        else
        {
            decimal losses = totalExpenses - totalEarnings;
            Console.WriteLine($"Have to find another job. Lost: {losses}.");
        }
    }

    static decimal SearchingForJewelsOrGold(string input, decimal priceOfJewels, decimal priceOfGold)
    {
        decimal totalEarnings = 0m;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '%')
            {
                totalEarnings += priceOfJewels;
            }
            else if (input[i] == '$')
            {
                totalEarnings += priceOfGold;
            }
        }
        return totalEarnings;
    }
}

