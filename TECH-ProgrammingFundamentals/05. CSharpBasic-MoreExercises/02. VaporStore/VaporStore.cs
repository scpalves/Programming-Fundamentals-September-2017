using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class VaporStore
{
    static void Main()
    {
        var currentBalance = decimal.Parse(Console.ReadLine());
        var games = Console.ReadLine();

        var totalSpent = 0m;

        while (games != "Game Time")
        {
            if (games == "OutFall 4")
            {
                var outFall = 39.99m;
                if (currentBalance < outFall)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currentBalance -= outFall;
                    totalSpent += outFall;
                    Console.WriteLine("Bought OutFall 4");
                }
            }
            else if (games == "CS: OG")
            {
                var cs = 15.99m;
                if (currentBalance < cs)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currentBalance -= cs;
                    totalSpent += cs;
                    Console.WriteLine("Bought CS: OG");
                }
            }
            else if (games == "Zplinter Zell")
            {
                var zpllinter = 19.99m;
                if (currentBalance < zpllinter)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currentBalance -= zpllinter;
                    totalSpent += zpllinter;
                    Console.WriteLine("Bought Zplinter Zell");
                }
            }
            else if (games == "Honored 2")
            {
                var honored = 59.99m;
                if (currentBalance < honored)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currentBalance -= honored;
                    totalSpent += honored;
                    Console.WriteLine("Bought Honored 2");
                }
            }
            else if (games == "RoverWatch")
            {
                var roverWatch = 29.99m;
                if (currentBalance < roverWatch)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currentBalance -= roverWatch;
                    totalSpent += roverWatch;
                    Console.WriteLine("Bought RoverWatch");
                }
            }
            else if (games == "RoverWatch Origins Edition")
            {
                var roverWatchOrginsEdition = 39.99m;
                if (currentBalance < roverWatchOrginsEdition)
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    currentBalance -= roverWatchOrginsEdition;
                    totalSpent += roverWatchOrginsEdition;
                    Console.WriteLine("Bought RoverWatch Origins Edition");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            games = Console.ReadLine();

        }
        Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");
    }
}

